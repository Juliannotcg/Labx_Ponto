using LabxPonto_Dao.Data.Context;
using LabxPonto_View.Views.Base;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP;
using DPFP.Capture;
using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
using System.IO;

namespace LabxPonto_View.Views.Biometria
{
    public partial class frmBaterPonto : Form, DPFP.Capture.EventHandler
    {
        AppDataContext context;
        Funcionario funcionario;
        Bitmap img = null;
        SampleConversion sp = new SampleConversion();
        Capture cp = new Capture();
        Sample sample = new Sample();
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        List<Funcionario> funcionarios;

        public delegate void OnTemplateEventHandler(DPFP.Template template);

        public event OnTemplateEventHandler OnTemplate;

        public frmBaterPonto(AppDataContext con)
        {
            InitializeComponent();
            context = con;
            funcionario = new Funcionario();
            cp = new DPFP.Capture.Capture();                
            cp.StartCapture();
            cp.EventHandler = this;
            Verificator = new DPFP.Verification.Verification();
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();  // Create a feature extractor
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);            // TODO: return features as a result?
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }

        public void Process(DPFP.Sample Sample)
        {
            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            if (features != null)
            {
                // Compare the feature set with our template
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                foreach (var item in funcionarios)
                {
                    Template = new Template();
                    Template.DeSerialize(item.Digital);
                    Verificator.Verify(features, Template, ref result);
                    if(result.Verified)
                    {
                        funcionario = item;
                        return;
                    }
                }

                if (result.Verified)
                {
                    MetroFramework.MetroMessageBox.Show(this, "A impressão digital foi verificada com sucesso.", "Verificação biométrica", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "A impressão digital não encontrada. Tente novamente.", "Verificação biométrica", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);

                }
            }
        }

        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            sp.ConvertToPicture(Sample, ref img);
            FuncionarioService funServ = new FuncionarioService(context);
            funcionarios = new List<Funcionario>();
            funcionarios = funServ.GetFuncionarios();
            byte[] bytes = Sample.Bytes;
            Process(Sample);
            PreencherTela();
        }

        public void PreencherTela()
        {
            
            if (funcionario != null)
            {
                this.Invoke(new Function(delegate () {
                txtNome.Text = funcionario.Nome + " " + funcionario.SobreNome;
                if (funcionario.Empresa != null)
                    txtEmpresa.Text = funcionario.Empresa.NomeFantasia;
                if (funcionario.Funcao != null)
                    txtFuncao.Text = funcionario.Funcao.NomeFuncao;
                if (funcionario.Funcao.Departamento != null)
                    txtDepartamento.Text = funcionario.Funcao.Departamento.NomeDepartamento;

                if (funcionario.Imagem != null)
                    if (funcionario.Imagem.Arquivo != null)
                    {
                        imgFoto.Image = preencherImagemByte(funcionario.Imagem.Arquivo);
                    }
                }));
            }
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            img = null;
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback)
        {
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public byte[] ConverterImagemParaBytes(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();

            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);

            return ms.ToArray();
        }

        public Image preencherImagemByte(byte[] imagemEmBytes)
        {
            MemoryStream ms = new MemoryStream();
            Image img;

            try
            {
                ms = new MemoryStream(imagemEmBytes, 0, imagemEmBytes.Length);
                ms.Write(imagemEmBytes, 0, imagemEmBytes.Length);
                img = Image.FromStream(ms, true);
                return (img);
            }
            catch (ArgumentException aex)
            {
                throw new InvalidOperationException("Imagem inválida");
            }
            finally
            {
                if (ms != null)
                {
                    ms.Close();
                    ms = null;
                }
            }
        }

        private void frmBaterPonto_Load(object sender, EventArgs e)
        {
           // Start();
        }

       
        private void frmBaterPonto_FormClosing(object sender, FormClosingEventArgs e)
        {
            cp.StopCapture();
        }
    }
}

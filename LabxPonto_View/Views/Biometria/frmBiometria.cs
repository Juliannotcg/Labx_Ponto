using LabxPonto_View.Views.Base;
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
using LabxPonto_Dao.Service;
using LabxPonto_Commons;
using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using System.IO;

namespace LabxPonto_View.Views.Biometria
{
    delegate void Function();
    public partial class frmBiometria : frmBaseCadastro//, DPFP.Capture.EventHandler
    {
        private ValidateCPF_CNPJ validate;
        private AppDataContext context;
        private Funcionario funcionario;
        private DPFP.Template Template;
        frmInscricaoBiometrica Enroller;

        Bitmap img = null;
        //SampleConversion sp = new SampleConversion();
        //Capture cp = new Capture();
        //Sample sample = new Sample();
        public frmBiometria(AppDataContext con)
        {
            InitializeComponent();
            txtCPF.CustomButton.Click += new System.EventHandler(txtCPF_Click);
            validate = new ValidateCPF_CNPJ();
            context = con;
            funcionario = new Funcionario();
            //cp.StartCapture();
            //cp.EventHandler = this;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBiometriaLer_Click(object sender, EventArgs e)
        {

        }

        //public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        //{
        //    sp.ConvertToPicture(Sample, ref img);
        //    imgDigital.Image = img;
            
        //}

        //public void OnFingerGone(object Capture, string ReaderSerialNumber)
        //{
        //}

        //public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        //{
        //    img = null;
        //}

        //public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        //{
        //}

        //public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        //{
        //}

        //public void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback)
        //{
        //}

        //private void frmBiometria_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    cp.StopCapture();
        //}

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtCPF.Text.Length == 11)
            {
                long CPF = Convert.ToInt64(txtCPF.Text);
                string CPFFormatado = String.Format(@"{0:000\.000\.000\-00}", CPF);
                txtCPF.Text = CPFFormatado;
            }
        }

        private void btDigital_Click(object sender, EventArgs e)
        {
            if (validar())
            {

                Enroller = new frmInscricaoBiometrica();
                Enroller.OnTemplate += this.OnTemplate;
                Enroller.ShowDialog();
                byte[] by = Template.Bytes;
                imgDigital.Image = Enroller.image;
            }

        }

        private void txtCPF_Click(object sender, EventArgs e)
        {

            if (validar())
            {
                FuncionarioService funServ = new FuncionarioService(context);
                funcionario = funServ.GetFuncionarioCPF(txtCPF.Text);

                if (funcionario != null)
                {
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
                            imgFoto.Image =  preencherImagemByte(funcionario.Imagem.Arquivo);
                        }

                    if(funcionario.ImagemDigital!=null)
                    {
                        imgDigital.Image = preencherImagemByte(funcionario.ImagemDigital); 
                    }
                }

            }

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
                return(img);
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

        public bool validar()
        {
            if (!validate.ValidarCPF_CNPJ(txtCPF.Text))
                errorProviderFunc.SetError(txtCPF, "O CPF informado é inválido.");

            return true;
        }

        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                //VerifyButton.Enabled = SaveButton.Enabled = (Template != null);
                if (Template != null)
                    MetroFramework.MetroMessageBox.Show(this, "A impressão digital foi capturada com sucesso.", "Inscrição biométrica", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
                else
                    MetroFramework.MetroMessageBox.Show(this, "A impressão digital não foi capturada corretamente. Tente novamente.", "Inscrição biométrica", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
            }));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                funcionario.Digital = Template.Bytes;
                funcionario.ImagemDigital = ConverterImagemParaBytes(imgDigital.Image);
                FuncionarioService servicoFuncionario = new FuncionarioService(context);
                if(servicoFuncionario.Update(funcionario))
                {
                    MetroFramework.MetroMessageBox.Show(this, "A impressão digital foi cadastrada com sucesso.", "Cadastro biométrico", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
                    this.Dispose();
                }

            }
        }

        public byte[] ConverterImagemParaBytes(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();

            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);

            return ms.ToArray();
        }

        private void imgDigital_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            frmVerificarBiometrica Verifier = new frmVerificarBiometrica();
            DPFP.Template template = new Template();
            template.DeSerialize(funcionario.Digital);
            Verifier.Verify(template);

            
        }
    }
}

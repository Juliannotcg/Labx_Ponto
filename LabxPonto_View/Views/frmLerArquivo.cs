using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace LabxPonto_View.Views
{
    public partial class frmLerArquivo : MetroForm
    {
        private AppDataContext context;
        private HorarioService servicoHorario;
        private FuncionarioService servicoFuncionario;
        private Funcionario funcionario;
        private HorarioExpediente horarioExpediente;

        public frmLerArquivo(AppDataContext con)
        {
            context = con;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }
        public void Confirmar()
        {
            LerXml(txtArquivo.Text);
        }

        public void LerXml(string caminho)
        {
            servicoHorario = new HorarioService(context);
            servicoFuncionario = new FuncionarioService(context);
            XmlDocument doc = new XmlDocument();
            doc.Load(caminho);

            XmlNodeList xmlHorarios = doc.GetElementsByTagName("Horarios");

            //Usando for para imprimir na tela

            for (int x = 0; x < xmlHorarios.Count; x++)
            {
                HorarioExpediente horarioExpediente = new HorarioExpediente();

                //Preenchendo Objeto.
                horarioExpediente.Funcionario.Id = int.Parse(xmlHorarios[x]["IdFuncionario"].InnerText);
                horarioExpediente.Funcionario.Nome = xmlHorarios[x]["NomeFuncionario"].InnerText;
                horarioExpediente.Funcionario.CPF = xmlHorarios[x]["CPFFuncionario"].InnerText;
                horarioExpediente.Data = Convert.ToDateTime(xmlHorarios[x]["Data"].InnerText);
                horarioExpediente.Entrada = Convert.ToDateTime(xmlHorarios[x]["Entrada"].InnerText);
                horarioExpediente.Saida = Convert.ToDateTime(xmlHorarios[x]["Saida"].InnerText);

                if (servicoFuncionario.GetFuncionarioCPFExiste(horarioExpediente.Funcionario.CPF))
                    servicoHorario.Insert(horarioExpediente);
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "O Funcionário: " + horarioExpediente.Funcionario.Nome.ToString() + ", " + "com CPF: " + horarioExpediente.Funcionario.Nome.ToString() + " não está cadastrado no banco principal, cadastre e leia o arquivo novamente", "Atenção!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                    return;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            txtArquivo.Text = openFileDialog.FileName;
            LerXml(openFileDialog.FileName);


        }

        private void txtArquivo_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtArquivo_DragDrop(object sender, DragEventArgs e)
        {
            string[] arquivos = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (arquivos != null && arquivos.Any())
                txtArquivo.Text = arquivos.First();
        }
    }
}

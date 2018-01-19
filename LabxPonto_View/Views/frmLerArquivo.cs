using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
using MetroFramework.Forms;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace LabxPonto_View.Views
{
    public partial class frmLerArquivo : MetroForm
    {
        private AppDataContext context;
        private HorarioService servico;

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
            servico = new HorarioService(context);

            //TO DO
            HorarioExpediente horarioExpediente = new HorarioExpediente();
            Funcionario funcionario = new Funcionario();

            XmlDocument doc = new XmlDocument();
            doc.Load(caminho);

            XmlNodeList xmlFuncionario = doc.GetElementsByTagName("DadosFuncionario");

            for (int i = 0; i < xmlFuncionario.Count; i++)
            {
                funcionario.Nome = xmlFuncionario[i]["Nome"].InnerText;
                funcionario.CPF = xmlFuncionario[i]["CPF"].InnerText;
            }

            XmlNodeList xmlHorarios = doc.GetElementsByTagName("Horarios");

            //Usando for para imprimir na tela
            for (int x = 0; x < xmlHorarios.Count; x++)
            {
                horarioExpediente.Data = Convert.ToDateTime(xmlHorarios[x]["Data"].InnerText);
                horarioExpediente.Entrada = Convert.ToDateTime(xmlHorarios[x]["Entrada"].InnerText);
                horarioExpediente.Saida = Convert.ToDateTime(xmlHorarios[x]["Saida"].InnerText);
            }

            servico.Insert(horarioExpediente);
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

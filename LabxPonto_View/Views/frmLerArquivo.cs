using LabxPonto_Dao.Model;
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
using System.Xml;

namespace LabxPonto_View.Views
{
    public partial class frmLerArquivo : MetroForm
    {
        public frmLerArquivo()
        {
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
        }

        public void LerXml(string caminho)
        {
            HorarioExpediente horarioExpediente = new HorarioExpediente();

            XmlDocument doc = new XmlDocument();
            doc.Load(caminho);

            XmlNodeList xmlFuncionario = doc.GetElementsByTagName("DadosFuncionario");

            for (int i = 0; i < xmlFuncionario.Count; i++)
            {
                horarioExpediente.Funcionario.Nome = xmlFuncionario[i]["Nome"].InnerText;
                horarioExpediente.Funcionario.CPF = xmlFuncionario[i]["CPF"].InnerText;
            }

            XmlNodeList xmlHorarios = doc.GetElementsByTagName("Horarios");

            //Usando for para imprimir na tela
            for (int x = 0; x < xmlHorarios.Count; x++)
            {
                horarioExpediente.Data = Convert.ToDateTime(xmlHorarios[x]["Data"].InnerText);
                horarioExpediente.Entrada = Convert.ToDateTime(xmlHorarios[x]["Entrada"].InnerText);
                horarioExpediente.Saida = Convert.ToDateTime(xmlHorarios[x]["Saida"].InnerText);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            txtArquivo.Text = openFileDialog.FileName;
            LerXml(openFileDialog.FileName);


        }
    }
}

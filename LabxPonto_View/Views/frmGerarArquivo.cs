using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LabxPonto_View.Views
{
    public partial class frmGerarArquivo : MetroForm
    {
        private AppDataContext context;

        public frmGerarArquivo(AppDataContext con )
        {
            context = con;
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        public void Confirmar()
        {
            HorarioService horarioService = new HorarioService(context);
            HorarioExpediente horarioExpediente = new HorarioExpediente();

            DateTime dateIni = dtDataIni.Value;
            DateTime dateFim = dtDataFim.Value;

            DataTable tabela = horarioService.GetHorarioXml(dateIni, dateFim);

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = NomeArquivo();
            saveFile.ShowDialog();

            if (gerarXml(tabela, saveFile.FileName))
                MetroFramework.MetroMessageBox.Show(this, "Arquivo gerado com sucesso", "Sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
            else
                MetroFramework.MetroMessageBox.Show(this, "O Arquivo não foi gerado, entrar em contato com o suporte.", "Erro!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
        }

        public string NomeArquivo()
        {
            string NomeArquivo = "";
            NomeArquivo = DateTime.Now.ToString("ddMMyyyy") + "Funcionario" + ".xml";

            return NomeArquivo;
        }
        public bool gerarXml(DataTable tabela, string caminho)
        {
            XmlTextWriter xml = new XmlTextWriter(caminho, System.Text.Encoding.GetEncoding("iso-8859-1"));

            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                xml.WriteStartElement("Funcionario");
                xml.WriteAttributeString("CPF", tabela.Rows[i]["CPF"].ToString());

                #region Dados do Funcionario

                xml.WriteStartElement("DadosFuncionario");
                xml.WriteElementString("Nome", tabela.Rows[i]["NomeFuncionario"].ToString());
                xml.WriteElementString("CPF", tabela.Rows[i]["CPF"].ToString());
                xml.WriteEndElement();

                #endregion
                
                xml.WriteStartElement("Horarios");
                xml.WriteElementString("Data", tabela.Rows[i]["Data"].ToString());
                xml.WriteElementString("Entrada", tabela.Rows[i]["Entrada"].ToString());
                xml.WriteElementString("Saida", tabela.Rows[i]["Saida"].ToString());
                xml.WriteEndElement();

                xml.WriteFullEndElement();
            }

            //escreve o XML para o arquivo e fecha o escritor
            xml.Close();
            XmlDocument doc = new XmlDocument();
            doc.XmlResolver = null;
            doc.Load(caminho);

            return (true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
    
}

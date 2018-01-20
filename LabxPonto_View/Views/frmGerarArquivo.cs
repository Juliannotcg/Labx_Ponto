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
        private HorarioExpediente horarioExpediente;
        private Funcionario funcionario;
        private HorarioService horarioService;

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
            horarioService = new HorarioService(context);
            horarioExpediente = new HorarioExpediente();

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
            xml.WriteStartElement("Funcionario");

            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                xml.WriteStartElement("Horarios");
                xml.WriteElementString("IdFuncionario", tabela.Rows[i]["IdFuncionario"].ToString());
                xml.WriteElementString("NomeFuncionario", tabela.Rows[i]["NomeFuncionario"].ToString());
                xml.WriteElementString("CPFFuncionario", tabela.Rows[i]["CPFFuncionario"].ToString());
                xml.WriteElementString("Data", tabela.Rows[i]["Data"].ToString());
                xml.WriteElementString("Entrada", tabela.Rows[i]["Entrada"].ToString());
                xml.WriteElementString("Saida", tabela.Rows[i]["Saida"].ToString());
                xml.WriteEndElement();
            }

            //escreve o XML para o arquivo e fecha o escritor
            xml.Close();
            XmlDocument doc = new XmlDocument();
            doc.XmlResolver = null;
            return (true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
    
}

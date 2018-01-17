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
        private AppDataContext con;

        public frmGerarArquivo()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            HorarioService horarioService = new HorarioService(con);
            HorarioExpediente horarioExpediente = new HorarioExpediente();

            DateTime dateIni = dtDataIni.Value;
            DateTime dateFim = dtDataFim.Value;

            horarioExpediente = horarioService.GetHorarioXml(dateIni, dateFim);

            gerarXml(horarioExpediente);

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = NomeArquivo();
            saveFile.ShowDialog();

            string xml = "";

            using (StreamWriter stream = new StreamWriter(saveFile.FileName, false, Encoding.UTF8))
            {
                //stream.Write();
            }

        }

        public string NomeArquivo()
        {
            string NomeArquivo = "";

            NomeArquivo = DateTime.Now.ToString("ddMMyyyy") + "Funcionario" + ".xml";

            return NomeArquivo;
        }
        public string gerarXml(HorarioExpediente horarioExpediente)
        {

            XmlTextWriter writer = new XmlTextWriter(@"c:", null);

            //inicia o documento xml
            writer.WriteStartDocument();

            //Dados do Funcionario
            writer.WriteStartElement("DadosPessoais");
            writer.WriteAttributeString("CPF", horarioExpediente.Funcionario.CPF.ToString());
            //Dados pessoais do Funcionário
            writer.WriteElementString("Nome", horarioExpediente.Funcionario.Nome.ToString());

            //for (int i = 0; i < horarioExpediente.; i++)
            //{
            //    //Dados pessoais do Funcionário
            //    //writer.WriteElementString("Data", funcionario.Horario.ToList());
            //    //writer.WriteElementString("SobreNome", funcionario.SobreNome.ToString());
            //    //writer.WriteElementString("RG", funcionario.RG.ToString());
            //    //Enncerra os dados pessoais do funcionário.

            //}

            writer.WriteEndElement();
            //Escreve o XML para o arquivo e fecha o objeto escritor
            writer.Close();

            return ("");
        }
    }
    
}

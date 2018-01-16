using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
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
    public partial class frmGerarArquivo : MetroForm
    {
        public frmGerarArquivo()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            buscarFuncionario("CPF");
        }

        public bool gerarXml(Funcionario funcionario)
        {

            XmlTextWriter writer = new XmlTextWriter(@"c:", null);

            //inicia o documento xml
            writer.WriteStartDocument();

            //Dados do Funcionario
            writer.WriteStartElement("DadosPessoais");
            writer.WriteAttributeString("CPF", funcionario.CPF.ToString());
            //Dados pessoais do Funcionário
            writer.WriteElementString("Nome", funcionario.Nome.ToString());
            writer.WriteElementString("SobreNome", funcionario.SobreNome.ToString());
            writer.WriteElementString("RG", funcionario.RG.ToString());

            for (int i = 0; i < funcionario.Horario.Count; i++)
            {
                //Dados pessoais do Funcionário
                //writer.WriteElementString("Data", funcionario.Horario.ToList());
                //writer.WriteElementString("SobreNome", funcionario.SobreNome.ToString());
                //writer.WriteElementString("RG", funcionario.RG.ToString());
                //Enncerra os dados pessoais do funcionário.
               
            }

            writer.WriteEndElement();
            //Escreve o XML para o arquivo e fecha o objeto escritor
            writer.Close();


            return (true);
        }

        public void buscarFuncionario(string CPF)
        {
            AppDataContext con = new AppDataContext();
            Funcionario funcionario = new Funcionario();
            FuncionarioService service = new FuncionarioService(con);

            funcionario = service.GetFuncionarioCPF(CPF);

            gerarXml(funcionario);
        }
    }
    
}

using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model.Configuracao;
using LabxPonto_View.Views.Base;
using Newtonsoft.Json;
using System;
using System.IO;

namespace LabxPonto_View.ConfiguracaoServidor
{
    public partial class frmConfiguracaoInicial : frmBaseCadastro
    {
        //private DepartamentoService servico;
        protected DadosConfiguracao configuracao;

        public frmConfiguracaoInicial(AppDataContext con)
        {
            InitializeComponent();
            editandoArquivoJson();
            //servico = new DepartamentoService(con);
        }

        public DadosConfiguracao Configuracao
        {
            get { return (configuracao); }
            set { configuracao = value; }
        }

        public bool validar()
        {
            if (String.IsNullOrEmpty(txtNomeBancoDeDados.Text))
                errorProviderConfig.SetError(txtNomeBancoDeDados, "Informe o nome do banco de dados.");

            if (String.IsNullOrEmpty(txtNomeServidor.Text))
                errorProviderConfig.SetError(txtNomeServidor, "Informe a descrição do departamento.");

            return ((errorProviderConfig.GetError(txtNomeBancoDeDados) == "") &&
                (errorProviderConfig.GetError(txtNomeServidor) == ""));
        }

        public void limparTela()
        {
            txtNomeBancoDeDados.Text = "";
            txtNomeServidor.Text = "";
            txtSenhaBanco.Text = "";
            txtUsuarioBanco.Text = "";
        }

        public void editandoArquivoJson()
        {
            string caminhoArquivo = "C:\\Users\\Julianno\\Documents\\ePonto\\Labx_Ponto\\LabxPonto_View\\ConfiguracaoBanco.json";

            JsonSerializer serializer = new JsonSerializer();

            //testc = new ConfiguracaoServidor();

            Configuracao = new DadosConfiguracao();
            
            Configuracao.NomeBancoDados = "sadf";
            Configuracao.NomeServidor = "zdv";
            Configuracao.UsuarioBancoDados = "sdfsdf";
            Configuracao.SenhaBancoDados = "sd";


            using (StreamWriter file = File.CreateText("C:\\Users\\Julianno\\Documents\\ePonto\\Labx_Ponto\\LabxPonto_View\\ConfiguracaoBanco.json"))
            {
                serializer.Serialize(file, Configuracao);

               
            }

            
        }
        public void limparErros()
        {
            errorProviderConfig.SetError(txtNomeBancoDeDados, "");
            errorProviderConfig.SetError(txtNomeBancoDeDados, "");
        }

        public void preencherDepartamento()
        {
            //departamento.NomeDepartamento = txtNomeDepartamento.Text;
            //departamento.Descricao = txtDescricaoDepartamento.Text;
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            limparErros();

        }

        private void inserir()
        {
          
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }
    }
}
    


using LabxPonto_Dao.Data.Context;
using LabxPonto_View.Views.Base;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Configuration;
using LabxPonto_Dao.Model;

namespace LabxPonto_View.ConfiguracaoServidor
{
    public partial class frmConfiguracaoInicial : frmBaseCadastro
    {
        protected ConfiguracaoBanco configuracao;

        public frmConfiguracaoInicial()
        {
            InitializeComponent();
            editandoArquivoJson();
        }

        public ConfiguracaoBanco Configuracao
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
            Configuracao = new ConfiguracaoBanco();
            Configuracao.BancoGerado = true;
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter file = File.CreateText(@"C:\Users\juliano.P21\Documents\ePonto\Labx_Ponto\LabxPonto_View\ConfiguracaoBanco.json"))
                   serializer.Serialize(file, Configuracao);
        }

        private void EditandoConnectionString()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["ConexaoPonto"].ConnectionString = $"Server= { txtNomeServidor.Text} ;Database= { txtNomeBancoDeDados.Text}; User ID= {txtUsuarioBanco.Text}; Password= {txtSenhaBanco.Text}; Trusted_Connection=False; Encrypt=False;";
            config.Save(ConfigurationSaveMode.Full);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
        public void limparErros()
        {
            errorProviderConfig.SetError(txtNomeBancoDeDados, "");
            errorProviderConfig.SetError(txtNomeBancoDeDados, "");
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            limparErros();
            EditandoConnectionString();
            editandoArquivoJson();
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
    


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
        protected AppDataContext _context;

        public frmConfiguracaoInicial(AppDataContext context)
        {
            _context = context;
            InitializeComponent();
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

            if (String.IsNullOrEmpty(txtUsuarioBanco.Text))
                errorProviderConfig.SetError(txtUsuarioBanco, "Informe a descrição do departamento.");

            if (String.IsNullOrEmpty(txtSenhaBanco.Text))
                errorProviderConfig.SetError(txtSenhaBanco, "Informe a descrição do departamento.");

            return ((errorProviderConfig.GetError(txtNomeBancoDeDados) == "") &&
                    (errorProviderConfig.GetError(txtNomeServidor) == "") &&
                    (errorProviderConfig.GetError(txtUsuarioBanco) == "") &&
                    (errorProviderConfig.GetError(txtSenhaBanco) == ""));
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
            var ConnectionString = $"Server= { txtNomeServidor.Text} ;Database= { txtNomeBancoDeDados.Text}; User ID= {txtUsuarioBanco.Text}; Password= {txtSenhaBanco.Text}; Trusted_Connection=False; Encrypt=False;";
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["ConexaoPonto"].ConnectionString = $"Server= { txtNomeServidor.Text} ;Database= { txtNomeBancoDeDados.Text}; User ID= {txtUsuarioBanco.Text}; Password= {txtSenhaBanco.Text}; Trusted_Connection=False; Encrypt=False;"; 
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        private bool TesteConexao()
        {
            var connectionString = $"Server= { txtNomeServidor.Text} ;Database= { txtNomeBancoDeDados.Text}; User ID= {txtUsuarioBanco.Text}; Password= {txtSenhaBanco.Text}; Trusted_Connection=False; Encrypt=False;";

            AppDataContext conte = new AppDataContext();
            conte.Database.Connection.ConnectionString = connectionString;

            if (conte.Database.Exists())
            {
                MetroFramework.MetroMessageBox.Show(this, "Banco cadastrado com sucesso.", "" , System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                return true;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Não foi possível realizar a conexão com o banco de dados.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }   
        }
        public void limparErros()
        {
            errorProviderConfig.SetError(txtNomeBancoDeDados, "");
            errorProviderConfig.SetError(txtNomeServidor, "");
            errorProviderConfig.SetError(txtSenhaBanco, "");
            errorProviderConfig.SetError(txtUsuarioBanco, "");
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            limparErros();
            EditandoConnectionString();
            editandoArquivoJson();
            TesteConexao();
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }
    }
}
    


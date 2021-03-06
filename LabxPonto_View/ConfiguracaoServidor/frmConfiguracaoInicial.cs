﻿using LabxPonto_Dao.Data.Context;
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

            var localizacao = Path.Combine(Directory.GetCurrentDirectory(), @"ConfiguracaoBanco.json");
            var retorno = localizacao.Replace("\\bin\\Debug", "");

            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter file = File.CreateText(retorno))
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
            _context.Database.Connection.ConnectionString = connectionString;

            try
            {
                _context.Database.CreateIfNotExists();
                MetroFramework.MetroMessageBox.Show(this, "Banco cadastrado com sucesso.", "Sucesso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                return true;
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Não foi possível realizar a conexão com o banco de dados.", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
                throw;
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

            if (!TesteConexao())
                return;
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void frmConfiguracaoInicial_Load(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Essa é a primeira vez que o sistema é executado nesse computador, será necessário configurar " +
                "o primeiro acesso.", "Informação", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
    }
}
    


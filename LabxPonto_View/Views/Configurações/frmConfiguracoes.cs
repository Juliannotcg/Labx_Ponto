using LabxPonto_View.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabxPonto_View.Views.Configurações
{
    public partial class frmConfiguracoes : frmBaseCadastro
    {
        public frmConfiguracoes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ConfigurarBanco();
        }

        public bool Validar()
        {
            if (String.IsNullOrEmpty(txtServidor.Text))
                errorProvider1.SetError(txtServidor, "Informe o nome do servidor.");

            if (String.IsNullOrEmpty(txtUsuario.Text))
                errorProvider1.SetError(txtUsuario, "Informe o nome do usuário.");

            if (String.IsNullOrEmpty(txtNomeBanco.Text))
                errorProvider1.SetError(txtNomeBanco, "Informe o nome banco de dados.");

            if (String.IsNullOrEmpty(txtSenha.Text))
                errorProvider1.SetError(txtSenha, "Informe a senha.");


            return ((errorProvider1.GetError(txtServidor) == "") &&
                     (errorProvider1.GetError(txtUsuario) == "") &&
                     (errorProvider1.GetError(txtSenha) == ""));
        }
        public void limparTela()
        {
            txtServidor.Text = "";
            txtUsuario.Text = "";
            txtNomeBanco.Text = "";
            txtSenha.Text = "";
        }

        public void limparErros()
        {
            errorProvider1.SetError(txtServidor, "");
            errorProvider1.SetError(txtUsuario, "");
            errorProvider1.SetError(txtNomeBanco, "");
            errorProvider1.SetError(txtSenha, "");
        }


        public void ConfigurarBanco()
        {
            if (Validar)
            {
                limparErros();

                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionStringsSection.ConnectionStrings["ConexaoPonto"].ConnectionString = "Server=" + txtServidor.Text + ";Database=" + txtNomeBanco.Text + "; User ID=" + txtUsuario.Text + ";Password=" + txtSenha.Text + ";Trusted_Connection=False; Encrypt=False;";
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");

                limparErros();
            }
        }
    }
}

using LabxPonto_Commons;
using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
using LabxPonto_View.Enums;
using LabxPonto_View.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabxPonto_View.Views.Usuário
{
    public partial class frmUsuarioCadastro : frmBaseCadastro
    {

        private Operacao operacao;
        private UsuarioServico servico;
        protected Usuario usuario;
        private AppDataContext context;

        public Usuario Usuario
        {
            get { return (usuario); }
            set { usuario = value; }
        }

        public bool validar()
        {
            string senha = txtSenha.Text;
            string confirmaSenha = txtConfirmaSenha.Text;

            if (String.IsNullOrEmpty(txtUsuario.Text))
                errorProviderUsu.SetError(txtUsuario, "Informe um usuário.");

            if (String.IsNullOrEmpty(txtSenha.Text))
                errorProviderUsu.SetError(txtSenha, "Informe a senha.");

            if (String.IsNullOrEmpty(txtConfirmaSenha.Text))
                errorProviderUsu.SetError(txtConfirmaSenha, "Informe a confirmação de senha.");

            if (senha != confirmaSenha)
                errorProviderUsu.SetError(txtConfirmaSenha, "A confirmação de senha deve ser igual a senha.");

            if (cbPerfil.SelectedIndex == 0)
                errorProviderUsu.SetError(cbPerfil, "Slecione um perfil");

            return ((errorProviderUsu.GetError(txtUsuario) == "") &&
                (errorProviderUsu.GetError(txtSenha) == "") &&
                (errorProviderUsu.GetError(txtConfirmaSenha) == "") &&
                (errorProviderUsu.GetError(cbPerfil) == ""));
        }

        public frmUsuarioCadastro(Operacao _operacao, AppDataContext con)
        {
            InitializeComponent();
            operacao = _operacao;
            servico = new UsuarioServico(con);
            context = con;
        }

        public void limparTela()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtConfirmaSenha.Text = "";
        }

        public void limparErros()
        {
            errorProviderUsu.SetError(txtUsuario, "");
            errorProviderUsu.SetError(txtSenha, "");
            errorProviderUsu.SetError(txtConfirmaSenha, "");
        }
        public void preencherTela()
        {
            txtUsuario.Text = usuario.Login;
            txtSenha.Text = usuario.Senha;
            txtConfirmaSenha.Text = usuario.Senha;
            cbPerfil.Text = usuario.Perfil;


            if (operacao == Operacao.Excluir ||
                operacao == Operacao.Visualizar)
            {
                txtUsuario.ReadOnly = true;
                txtSenha.ReadOnly = true;
                cbPerfil.Enabled = false;
            }
        }
        public void preencherUsuario()
        {
            Criptografar criptografar = new Criptografar();
            string senha = criptografar.Base64Encode(txtSenha.Text);
            usuario.Login = txtUsuario.Text;
            usuario.Perfil = cbPerfil.Text;
            usuario.Senha = senha;
        }
        private void inserir()
        {
            if (validar())
            {
                usuario = new Usuario();
                preencherUsuario();
                if (servico.Insert(usuario))
                {
                    MetroFramework.MetroMessageBox.Show(this, "O usuário " + usuario.Login + " foi cadastrado no sistema com sucesso!", "Cadastrado com sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
                    limparTela();
                }
            }
        }

        private void excluir()
        {
            if (servico.Delete(usuario))
            {
                MetroFramework.MetroMessageBox.Show(this, "O usuário " + usuario.Login + " foi deletado do sistema com sucesso!", "Excluído com sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
                this.Dispose();
            }
        }

        private void editar()
        {
            if (validar())
            {
                preencherUsuario();
                if (servico.Update(usuario))
                {
                    MetroFramework.MetroMessageBox.Show(this, "O usuário " + usuario.Login + " foi alterado com sucesso!", "Alterado com sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
                    this.Dispose();
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            limparErros();

            switch (operacao)
            {
                case Operacao.Inserir:
                    inserir();
                    break;
                case Operacao.Excluir:
                    excluir();
                    break;
                case Operacao.Editar:
                    editar();
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmUsuarioCadastro_Load(object sender, EventArgs e)
        {
            if(operacao != Operacao.Inserir)
                preencherTela();

            if (this.StyleManager.Theme == MetroFramework.MetroThemeStyle.Dark)
            {
                lbUsuario.ForeColor = Color.WhiteSmoke;
                lbSenha.ForeColor = Color.WhiteSmoke;
                lbConfirmarSenha.ForeColor = Color.WhiteSmoke;
                lbPerfil.ForeColor = Color.WhiteSmoke;
                this.Refresh();
            }
        }
    }
}

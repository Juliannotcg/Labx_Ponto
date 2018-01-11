using LabxPonto_Commons;
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

namespace LabxPonto_View.Views
{
    public partial class frmLogin : MetroForm
    {
        private UsuarioServico servico;
        protected Usuario usuario;
        private AppDataContext context;
        private Criptografar cript;

        public Usuario Usuario
        {
            get { return (usuario); }
            set { usuario = value; }
        }

        public frmLogin(AppDataContext con)
        {
            InitializeComponent();
            usuario = new Usuario();
            servico = new UsuarioServico(con);
            context = con;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            preencherUsuario();
            if(validar(usuario.Login, usuario.Senha))
            {
                this.DialogResult = DialogResult.OK;
                this.Dispose();
                
            }
            else
            {
                DialogResult = DialogResult.None;
            }
            
        }

        public void preencherUsuario()
        {
            usuario.Login = txtUsuario.Text;
            usuario.Senha = txtSenha.Text;
        }
        public bool validar(string usuario, string senha)
        {
            cript = new Criptografar();
            string senhaCript = "";

            if (String.IsNullOrEmpty(txtUsuario.Text))
                errorProviderLogin.SetError(txtUsuario, "Informe o usuário");
            else
            {
                if (!servico.GetUsuarioLogin(usuario))
                {
                    MetroFramework.MetroMessageBox.Show(this, "O usuário \"" + txtUsuario.Text + "\" não foi encontrado!", "Atenção!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                    return false;
                }
            }

            if (String.IsNullOrEmpty(txtSenha.Text))
                errorProviderLogin.SetError(txtSenha, "Informe a senha.");
            else
            {
                senhaCript =  cript.Base64Encode(senha);
                if(!servico.GetSenha(senhaCript))
                {
                    MetroFramework.MetroMessageBox.Show(this, "A senha está incorreta!", "Atenção!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                    return false;
                }
            }

            return ((errorProviderLogin.GetError(txtUsuario) == "") &&
                     (errorProviderLogin.GetError(txtSenha) == ""));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void validar(string senha)
        {
            Criptografar cript = new Criptografar();
            cript.Base64Decode(senha);
        }
    }
}

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

        public Usuario Usuario
        {
            get { return (usuario); }
            set { usuario = value; }
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            preencherUsuario();
            validar(usuario.Senha);
        }

        public void preencherUsuario()
        {
            usuario.Login = txtUsuario.Text;
            usuario.Senha = txtSenha.Text;
        }
        public void validar(string senha)
        {
            Criptografar cript = new Criptografar();
            cript.Base64Decode(senha);
        }
    }
}

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
    public partial class frmUsuario : frmBase
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btNovo_Click_1(object sender, EventArgs e)
        {
            frmUsuarioCadastro janela = new frmUsuarioCadastro();
            janela.Show();
        }
    }
}

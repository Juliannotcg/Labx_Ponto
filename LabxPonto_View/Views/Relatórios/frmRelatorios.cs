using LabxPonto_View.Views.Base;
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
    public partial class frmRelatorios : frmBaseCadastro
    {
        public frmRelatorios()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtCPF_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Funcionalidade em desenvolvimento", "Atenção!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

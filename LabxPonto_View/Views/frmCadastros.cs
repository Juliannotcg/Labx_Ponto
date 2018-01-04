using LabxPonto_View.Forms;
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
    public partial class frmCadastros : MetroForm
    {
        public frmCadastros()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario janela = new frmCadastroFuncionario();
            janela.ShowDialog();
        }
    }
}

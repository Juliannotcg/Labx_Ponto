using MetroFramework.Forms;

namespace LabxPonto_View.Views.Suporte
{
    public partial class frmSuporte : MetroForm
    {
        public frmSuporte()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.lifetechoficial.com.br");
        }
    }
}

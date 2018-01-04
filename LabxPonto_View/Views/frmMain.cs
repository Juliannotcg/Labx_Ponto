using LabxPonto_View.Forms;
using MetroFramework.Forms;

namespace LabxPonto_View.Views
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void mtCadastro_Click(object sender, System.EventArgs e)
        {
            frmCadastros janela = new frmCadastros();
            janela.ShowDialog();
        }
    }
}

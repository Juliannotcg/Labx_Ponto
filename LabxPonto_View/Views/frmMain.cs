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
        }

        private void metroTile2_Click(object sender, System.EventArgs e)
        {
            frmCadastroFuncionario janela = new frmCadastroFuncionario();
            janela.ShowDialog();
        }
    }
}

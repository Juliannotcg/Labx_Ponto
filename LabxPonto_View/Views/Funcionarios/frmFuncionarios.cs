using LabxPonto_View.Views.Base;

namespace LabxPonto_View.Views.Funcionarios
{
    public partial class frmFuncionarios : frmBase
    { 
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void btNovo_Click_1(object sender, System.EventArgs e)
        {
            frmFuncionarioCadastro janela = new frmFuncionarioCadastro();
            janela.Show();
        }
    }
}

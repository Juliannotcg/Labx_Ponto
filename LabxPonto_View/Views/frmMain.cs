using LabxPonto_View.Views.Configurações;
using LabxPonto_View.Views.Departamentos;
using LabxPonto_View.Views.Empresas;
using LabxPonto_View.Views.Funcionarios;
using LabxPonto_View.Views.Funções;
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
            frmFuncionarios janela = new frmFuncionarios();
            janela.ShowDialog();
        }

        private void btnDepartamento_Click(object sender, System.EventArgs e)
        {
            frmDepartamentos janela = new frmDepartamentos();
            janela.ShowDialog();
        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void mtConfiguracoes_Click(object sender, System.EventArgs e)
        {
            frmConfiguracoes janela = new frmConfiguracoes();
            janela.Show();
        }

        private void btnFuncoes_Click(object sender, System.EventArgs e)
        {
            frmFuncoes janela = new frmFuncoes();
            janela.ShowDialog();
        }

        private void btnEmpresa_Click(object sender, System.EventArgs e)
        {
            frmEmpresas janela = new frmEmpresas();
            janela.ShowDialog();
        }
    }
}

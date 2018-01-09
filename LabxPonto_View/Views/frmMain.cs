using LabxPonto_Dao.Data.Context;
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
        AppDataContext context = new AppDataContext();
        public frmMain()
        {
            InitializeComponent();
            
        }

        public void mtCadastro_Click(object sender, System.EventArgs e)
        {
            frmFuncionarios janela = new frmFuncionarios(context);
            janela.ShowDialog();
        }

        private void btnDepartamento_Click(object sender, System.EventArgs e)
        {
            frmDepartamentos janela = new frmDepartamentos(context);
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
            frmFuncoes janela = new frmFuncoes(context);
            janela.ShowDialog();
        }

        private void btnEmpresa_Click(object sender, System.EventArgs e)
        {
            frmEmpresas janela = new frmEmpresas(context);
            janela.ShowDialog();
        }

        private void metroTile2_Click(object sender, System.EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Funcionalidade em desenvolvimento", "Atenção!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
        }

        private void metroTile3_Click(object sender, System.EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Funcionalidade em desenvolvimento", "Atenção!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
        }

        private void metroTile1_Click(object sender, System.EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Funcionalidade em desenvolvimento", "Atenção!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
        }
    }
}

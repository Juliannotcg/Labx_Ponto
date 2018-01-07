using LabxPonto_Dao.Model;
using LabxPonto_View.Enums;
using LabxPonto_View.Views.Base;

namespace LabxPonto_View.Views.Empresas
{
    public partial class frmEmpresas : frmBase
    {
        private frmEmpresaCadastro cadastro;

        public frmEmpresas()
        {
            InitializeComponent();
        }

        private void btNovo_Click_1(object sender, System.EventArgs e)
        {
            cadastro = new frmEmpresaCadastro(Operacao.Inserir);
            cadastro.Empresa = new Empresa();
            cadastro.ShowDialog();
        }
    }
}

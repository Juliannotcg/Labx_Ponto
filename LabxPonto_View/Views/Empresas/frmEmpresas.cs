using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
using LabxPonto_View.Enums;
using LabxPonto_View.Views.Base;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LabxPonto_View.Views.Empresas
{
    public partial class frmEmpresas : frmBase
    {
        private frmEmpresaCadastro cadastro;
        private EmpresaService servico;
        private Empresa empresa;

        public frmEmpresas()
        {
            InitializeComponent();
            servico = new EmpresaService();
            empresa = new Empresa();
        }

        public void preencherGrid()
        {
            dgEmpresas.DataSource = servico.GetEmpresaGrid();
        }

        public Empresa retornarEmpresaSelecionado()
        {
            empresa.Id = (int)dgEmpresas.CurrentRow.Cells["Id"].Value;
            empresa = servico.GetEmpresa(empresa.Id);
            return empresa;
        }

        private void btNovo_Click_1(object sender, System.EventArgs e)
        {
            cadastro = new frmEmpresaCadastro(Operacao.Inserir);
            cadastro.Empresa = new Empresa();
            cadastro.ShowDialog();
        }

        private void frmEmpresas_Load(object sender, System.EventArgs e)
        {
            preencherGrid();
        }

        private void btAlterar_Click_1(object sender, System.EventArgs e)
        {
            cadastro = new frmEmpresaCadastro(Operacao.Editar);
            cadastro.Empresa = retornarEmpresaSelecionado();
            cadastro.preencherTela();
            cadastro.ShowDialog();
        }

        private void btnVisualizar_Click(object sender, System.EventArgs e)
        {
            cadastro = new frmEmpresaCadastro(Operacao.Visualizar);
            cadastro.Empresa = retornarEmpresaSelecionado();
            cadastro.preencherTela();
            cadastro.ShowDialog();
        }

        private void btExcluir_Click_1(object sender, System.EventArgs e)
        {
            cadastro = new frmEmpresaCadastro(Operacao.Excluir);
            cadastro.Empresa = retornarEmpresaSelecionado();
            cadastro.preencherTela();
            cadastro.ShowDialog();
        }
    }
}

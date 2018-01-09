using LabxPonto_Dao.Data.Context;
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
        AppDataContext context;

        public frmEmpresas(AppDataContext con)
        {
            InitializeComponent();
            servico = new EmpresaService(con);
            empresa = new Empresa();
            context = con;
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
            cadastro = new frmEmpresaCadastro(Operacao.Inserir, context);
            cadastro.Empresa = new Empresa();
            cadastro.ShowDialog();
        }

        private void frmEmpresas_Load(object sender, System.EventArgs e)
        {
            preencherGrid();
        }

        private void btAlterar_Click_1(object sender, System.EventArgs e)
        {
            cadastro = new frmEmpresaCadastro(Operacao.Editar, context);
            cadastro.Empresa = retornarEmpresaSelecionado();
            cadastro.preencherTela();
            cadastro.ShowDialog();
        }

        private void btnVisualizar_Click(object sender, System.EventArgs e)
        {
            cadastro = new frmEmpresaCadastro(Operacao.Visualizar, context);
            cadastro.Empresa = retornarEmpresaSelecionado();
            cadastro.preencherTela();
            cadastro.ShowDialog();
        }

        private void btExcluir_Click_1(object sender, System.EventArgs e)
        {
            cadastro = new frmEmpresaCadastro(Operacao.Excluir, context);
            cadastro.Empresa = retornarEmpresaSelecionado();
            cadastro.preencherTela();
            cadastro.ShowDialog();
        }
    }
}

using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
using LabxPonto_View.Enums;
using LabxPonto_View.Views.Base;
using System;

namespace LabxPonto_View.Views.Funções
{
    public partial class frmFuncoes : frmBase
    {
        private FuncaoService servico;
        private frmFuncaoCadastro cadastro;
        private Funcao funcao;

        public frmFuncoes()
        {
            InitializeComponent();
            servico = new FuncaoService();
            funcao = new Funcao();
        }

        public void preencherGrid()
        {
            dgFuncao.DataSource = servico.GetFuncaoGrid();
        }

        public Funcao retornarFuncaoSelecionado()
        {
            funcao.Id = (int)dgFuncao.CurrentRow.Cells["Id"].Value;
            funcao = servico.GetFuncao(funcao.Id);
            return funcao;
        }

        private void btNovo_Click_1(object sender, System.EventArgs e)
        {
            cadastro = new frmFuncaoCadastro(Operacao.Inserir);
            cadastro.Funcao = new Funcao();
            cadastro.ShowDialog();
            preencherGrid();
        }

        private void btAlterar_Click_1(object sender, System.EventArgs e)
        {
            cadastro = new frmFuncaoCadastro(Operacao.Editar);
            cadastro.Funcao = retornarFuncaoSelecionado();
            cadastro.ShowDialog();
            preencherGrid();
        }

        private void btExcluir_Click_1(object sender, System.EventArgs e)
        {
            cadastro = new frmFuncaoCadastro(Operacao.Excluir);
            cadastro.Funcao = retornarFuncaoSelecionado();
            cadastro.ShowDialog();
            preencherGrid();
        }

        private void frmFuncoes_Load(object sender, EventArgs e)
        {
            preencherGrid();
        }
    }
}

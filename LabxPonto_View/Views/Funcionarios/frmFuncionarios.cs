using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
using LabxPonto_View.Enums;
using LabxPonto_View.Views.Base;
using System;
using System.Collections.Generic;

namespace LabxPonto_View.Views.Funcionarios
{
    public partial class frmFuncionarios : frmBase
    { 
        private FuncionarioService servico;
        private frmFuncionarioCadastro cadastro;
        private Funcionario funcionario;

        public frmFuncionarios()
        {
            InitializeComponent();
            servico = new FuncionarioService();
            funcionario = new Funcionario();
        }

        public void preencherGrid()
        {
            dgFuncionarios.DataSource = servico.GetFuncionarioGrid();
        }

        public Funcionario retornarFuncionarioSelecionado()
        {
            funcionario.Id = (int)dgFuncionarios.CurrentRow.Cells["Id"].Value;
            funcionario = servico.GetFuncionario(funcionario.Id);
            return funcionario;
        }

        private void btNovo_Click_1(object sender, EventArgs e)
        {
            cadastro = new frmFuncionarioCadastro(Operacao.Inserir);
            cadastro.Funcionario = new Funcionario();
            cadastro.ShowDialog();
            preencherGrid();
        }

        private void btExcluir_Click_1(object sender, EventArgs e)
        {
            //cadastro = new frmFuncionarioCadastro(Operacao.Excluir);
            //cadastro.Funcionario = retornarFuncionarioSelecionado();
            //cadastro.ShowDialog();
            //preencherGrid();
        }

        private void frmFuncionarios_Load(object sender, System.EventArgs e)
        {
            preencherGrid();
        }

        private void btAlterar_Click_2(object sender, EventArgs e)
        {
            cadastro = new frmFuncionarioCadastro(Operacao.Editar);
            cadastro.Funcionario = retornarFuncionarioSelecionado();
            cadastro.ShowDialog();
            preencherGrid();
        }

        private void btExcluir_Click_2(object sender, EventArgs e)
        {

        }
    }
}

using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
using LabxPonto_View.Enums;
using LabxPonto_View.Views.Base;
using System;
using System.Collections.Generic;

namespace LabxPonto_View.Views.Departamentos
{
    public partial class frmDepartamentos : frmBase
    {
        private DepartamentoService servico;
        private frmDepartamentoCadastro cadastro;
        private Departamento departamento;
        private AppDataContext context;
        public frmDepartamentos(AppDataContext con)
        {
            InitializeComponent();
            servico = new DepartamentoService(con);
            departamento = new Departamento();
            context = con;
        }

        public void preencherGrid()
        {
            List<Departamento> lista = servico.GetDepartamento();
            dgDepartamentos.DataSource = lista;
        }

        public Departamento retornarDepartamentoSelecionado()
        {
            departamento.Id = (int)dgDepartamentos.Rows[dgDepartamentos.CurrentRow.Index].Cells["Id"].Value;
            departamento = servico.GetDepartamento(departamento.Id);
            return departamento;
        }

        private void btNovo_Click_1(object sender, EventArgs e)
        {
            cadastro = new frmDepartamentoCadastro(Operacao.Inserir,context);
            cadastro.StyleManager = this.StyleManager;
            cadastro.Departamento = new Departamento();
            cadastro.ShowDialog();
            preencherGrid();
        }

        private void btAlterar_Click_1(object sender, EventArgs e)
        {
            cadastro = new frmDepartamentoCadastro(Operacao.Editar, context);
            cadastro.StyleManager = this.StyleManager;
            cadastro.Departamento = retornarDepartamentoSelecionado();
            cadastro.ShowDialog();
            preencherGrid();
        }

        private void btExcluir_Click_1(object sender, EventArgs e)
        {
            cadastro = new frmDepartamentoCadastro(Operacao.Excluir, context);
            cadastro.StyleManager = this.StyleManager;
            cadastro.Departamento = retornarDepartamentoSelecionado();
            if(!servico.VerificarDependencias(departamento.Id))
            {
                MetroFramework.MetroMessageBox.Show(this, "O Department \""+ departamento.NomeDepartamento+"\" não pode ser deletado, existem uma ou mais Funções cadastradas com esse Department. \nAntes de excluir, será necessário desvinculá-lo de todas as Funções relacionadas.", "Atenção!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                return;
            }
            cadastro.ShowDialog();
            preencherGrid();
        }

        private void frmDepartamentos_Load(object sender, EventArgs e)
        {
            preencherGrid();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            cadastro = new frmDepartamentoCadastro(Operacao.Visualizar, context);
            cadastro.StyleManager = this.StyleManager;
            cadastro.Departamento = retornarDepartamentoSelecionado();
            cadastro.preencherTela();
            cadastro.ShowDialog();
            preencherGrid();
        }
    }
}

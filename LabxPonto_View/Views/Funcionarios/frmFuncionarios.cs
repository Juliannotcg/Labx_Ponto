﻿using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
using LabxPonto_View.Enums;
using LabxPonto_View.Views.Base;
using System;

namespace LabxPonto_View.Views.Funcionarios
{
    public partial class frmFuncionarios : frmBase
    { 
        private FuncionarioService servico;
        private EmpresaService empresaServico;
        private FuncaoService funcaoServico;
        private DepartamentoService departamentoServico;
        private frmFuncionarioCadastro cadastro;
        private Funcionario funcionario;
        private AppDataContext context;

        public frmFuncionarios(AppDataContext con)
        {
            InitializeComponent();
            txtCPF.CustomButton.Click += new EventHandler(txtCPF_Click);
            servico = new FuncionarioService(con);
            empresaServico = new EmpresaService(con);
            funcaoServico = new FuncaoService(con);
            departamentoServico = new DepartamentoService(con);
            funcionario = new Funcionario();
            context = con;
        }

        public void preencherGrid()
        {
            dgFuncionarios.DataSource = servico.GetFuncionarioGrid();
        }
        public void preencherGridPesquisa()
        {
            if (!String.IsNullOrEmpty(txtCPF.Text))
                dgFuncionarios.DataSource = servico.GetFuncionarioGridCPF(txtCPF.Text);
        }

        public Funcionario retornarFuncionarioSelecionado()
        {
            funcionario = new Funcionario();
            funcionario.Id = (int)dgFuncionarios.Rows[dgFuncionarios.CurrentRow.Index].Cells["Id"].Value;
            funcionario = servico.GetFuncionario(funcionario.Id);
            return funcionario;
        }

        private void btNovo_Click_1(object sender, EventArgs e)
        {
            if (!Validar()) return;
            cadastro = new frmFuncionarioCadastro(Operacao.Inserir, context);
            cadastro.StyleManager = this.StyleManager;
            cadastro.Funcionario = new Funcionario();
            cadastro.ShowDialog();
            preencherGrid();
        }

        private bool Validar()
        {
            var textErro = "";

            if (!ValidarExisteEmpresa())
                textErro += " empresas"; 

            if (!ValidarExisteDepartamento())
                textErro += " ,departamentos";

            if (!ValidarExisteFuncao())
                textErro += " ,funções ";

            if (textErro != "")
            {
                MetroFramework.MetroMessageBox.Show(this, $"Ainda não existem {textErro} cadastrados no sistema, vá ao respectivo menu e cadastre.", "Atenção!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                return false;
            }
            return true;
        }

        private bool ValidarExisteEmpresa()
        {
            var resultado = empresaServico.GetEmpresa();
            return resultado.Count > 0;
        }

        private bool ValidarExisteDepartamento()
        {
            var resultado = departamentoServico.GetDepartamento();
            return resultado.Count > 0;
        }
        private bool ValidarExisteFuncao()
        {
            var resultado = funcaoServico.GetFuncoes();
            return resultado.Count > 0;
        }
        private void btExcluir_Click_1(object sender, EventArgs e)
        {
        }

        private void frmFuncionarios_Load(object sender, System.EventArgs e)
        {
            preencherGrid();
        }

        private void btAlterar_Click_2(object sender, EventArgs e)
        {
            cadastro = new frmFuncionarioCadastro(Operacao.Editar, context);
            cadastro.StyleManager = this.StyleManager;
            cadastro.Funcionario = retornarFuncionarioSelecionado();
            cadastro.ShowDialog();
            preencherGrid();
        }

        private void btExcluir_Click_2(object sender, EventArgs e)
        {
            cadastro = new frmFuncionarioCadastro(Operacao.Excluir, context);
            cadastro.StyleManager = this.StyleManager;
            cadastro.Funcionario = retornarFuncionarioSelecionado();
            cadastro.ShowDialog();
            preencherGrid();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            cadastro = new frmFuncionarioCadastro(Operacao.Visualizar, context);
            cadastro.Funcionario = retornarFuncionarioSelecionado();
            cadastro.StyleManager = this.StyleManager;
            cadastro.ShowDialog();
            preencherGrid();
        }

        private void txtCPF_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text.Length == 11)
            {
                long CPF = Convert.ToInt64(txtCPF.Text);
                string CPFFormatado = String.Format(@"{0:000\.000\.000\-00}", CPF);
                txtCPF.Text = CPFFormatado;
            }

            preencherGridPesquisa();
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (txtCPF.Text.Length == 11)
            {
                long CPF = Convert.ToInt64(txtCPF.Text);
                string CPFFormatado = String.Format(@"{0:000\.000\.000\-00}", CPF);
                txtCPF.Text = CPFFormatado;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            funcionario.Id = (int)dgFuncionarios.Rows[dgFuncionarios.CurrentRow.Index].Cells["Id"].Value;
            var resposta = servico.GetRelatorioFuncionarioSlecionado(funcionario.Id);
            frmRltDadosFuncionario janela = new frmRltDadosFuncionario(resposta);
            janela.Show();
        }
    }
}

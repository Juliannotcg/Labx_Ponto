﻿using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
using LabxPonto_View.Enums;
using LabxPonto_View.Views.Base;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LabxPonto_View.Views.Funcionarios
{
    public partial class frmFuncionarios : frmBase
    { 
        private FuncionarioService servico;
        private frmFuncionarioCadastro cadastro;
        private Funcionario funcionario;
        private AppDataContext context;

        public frmFuncionarios(AppDataContext con)
        {
            InitializeComponent();
            txtCPF.CustomButton.Click += new EventHandler(txtCPF_Click);
            servico = new FuncionarioService(con);
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
            funcionario.Id = (int)dgFuncionarios.Rows[dgFuncionarios.CurrentRow.Index].Cells["Id"].Value;
            funcionario = servico.GetFuncionario(funcionario.Id);
            return funcionario;
        }

        private void btNovo_Click_1(object sender, EventArgs e)
        {
            cadastro = new frmFuncionarioCadastro(Operacao.Inserir, context);
            cadastro.StyleManager = this.StyleManager;
            cadastro.Funcionario = new Funcionario();
            cadastro.ShowDialog();
            preencherGrid();
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
    }
}

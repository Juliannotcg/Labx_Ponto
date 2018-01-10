﻿using LabxPonto_Dao.Data.Context;
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
        private AppDataContext context;

        public frmFuncoes(AppDataContext con)
        {
            InitializeComponent();
            servico = new FuncaoService(con);
            funcao = new Funcao();
            context = con;
        }

        public void preencherGrid()
        {
            dgFuncao.DataSource = servico.GetFuncaoGrid();
        }

        public Funcao retornarFuncaoSelecionado()
        {
            funcao.Id = (int)dgFuncao.Rows[dgFuncao.CurrentRow.Index].Cells["Id"].Value;
            funcao = servico.GetFuncao(funcao.Id);
            return funcao;
        }

        private void btNovo_Click_1(object sender, System.EventArgs e)
        {
            cadastro = new frmFuncaoCadastro(Operacao.Inserir, context);
            cadastro.StyleManager = this.StyleManager;
            cadastro.Funcao = new Funcao();
            cadastro.ShowDialog();
            preencherGrid();
        }

        private void btAlterar_Click_1(object sender, System.EventArgs e)
        {
            cadastro = new frmFuncaoCadastro(Operacao.Editar, context);
            cadastro.StyleManager = this.StyleManager;
            cadastro.Funcao = retornarFuncaoSelecionado();
            cadastro.ShowDialog();
            preencherGrid();
        }

        private void btExcluir_Click_1(object sender, System.EventArgs e)
        {
            cadastro = new frmFuncaoCadastro(Operacao.Excluir, context);
            cadastro.StyleManager = this.StyleManager;
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

﻿using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
using LabxPonto_View.Enums;
using LabxPonto_View.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabxPonto_View.Views.Departamentos
{
    public partial class frmDepartamentos : frmBase
    {
        private DepartamentoService servico;
        private frmDepartamentoCadastro cadastro;
        private Departamento departamento;

        public frmDepartamentos()
        {
            InitializeComponent();
            servico = new DepartamentoService();
            departamento = new Departamento();
        }

        public void preencherGrid()
        {
            List<Departamento> lista = servico.GetDepartamento();
            dgDepartamentos.DataSource = lista;
        }

        public Departamento retornarDepartamentoSelecionado()
        {
            departamento.Id = (int)dgDepartamentos.CurrentRow.Cells["Id"].Value;
            departamento = servico.GetDepartamento(departamento.Id);
            return departamento;
        }

        private void btNovo_Click_1(object sender, EventArgs e)
        {
            cadastro = new frmDepartamentoCadastro(Operacao.Inserir);
            cadastro.Departamento = new Departamento();
            cadastro.ShowDialog();
            preencherGrid();
        }

        private void btAlterar_Click_1(object sender, EventArgs e)
        {
            cadastro = new frmDepartamentoCadastro(Operacao.Editar);
            cadastro.Departamento = retornarDepartamentoSelecionado();
            cadastro.ShowDialog();
            preencherGrid();
        }

        private void btExcluir_Click_1(object sender, EventArgs e)
        {
            cadastro = new frmDepartamentoCadastro(Operacao.Excluir);
            cadastro.Departamento = retornarDepartamentoSelecionado();
            cadastro.ShowDialog();
            preencherGrid();
        }

        private void frmDepartamentos_Load(object sender, EventArgs e)
        {
            preencherGrid();
        }
    }
}
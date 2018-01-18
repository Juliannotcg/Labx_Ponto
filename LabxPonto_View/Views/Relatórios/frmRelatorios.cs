﻿using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Service;
using LabxPonto_View.Views.Base;
using LabxPonto_View.Views.Funcionarios;
using System;

namespace LabxPonto_View.Views
{
    public partial class frmRelatorios : frmBaseCadastro
    {
        private AppDataContext context;
        private FuncionarioService servico;

        public frmRelatorios(AppDataContext con)
        {
            context = con;
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtCPF_Click(object sender, EventArgs e)
        {

        }

        public bool Validar()
        {
            if (String.IsNullOrEmpty(txtCPF.Text))
                errorProviderRlt.SetError(txtCPF, "Informe o número do CPF.");

            if (dtDataIni.Value < dtDataFim.Value)
                errorProviderRlt.SetError(dtDataFim, "A data inicial não pode ser menor que a data inicial.");

            return ((errorProviderRlt.GetError(txtCPF) == "") &&
                (errorProviderRlt.GetError(dtDataFim) == ""));
        }

        public void LimparTela()
        {
            txtCPF.Text = "";
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        public void Confirmar()
        {
            if (Validar())
            {
                frmRltFuncionario janela = new frmRltFuncionario(context, txtCPF.Text);
                janela.Show();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            servico = new FuncionarioService(context);

            bool CPFexiste = false;

            if (txtCPF.Text.Length == 11)
            {
                long CPF = Convert.ToInt64(txtCPF.Text);
                string CPFFormatado = String.Format(@"{0:000\.000\.000\-00}", CPF);
                txtCPF.Text = CPFFormatado;
            }
           
            if (!String.IsNullOrEmpty(txtCPF.Text))
            {
                if (servico.GetFuncionarioCPF(txtCPF.Text) != null)
                    CPFexiste = true;
            }
            if (!CPFexiste)
            {
                MetroFramework.MetroMessageBox.Show(this, "Esse CPF não existe cadastrado no sistema no sistema.", "Atenção!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                LimparTela();
                txtCPF.Focus();
                return;
            }
        }
    }
}

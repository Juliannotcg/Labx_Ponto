using LabxPonto_Dao.Data.Context;
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
            if (rbPonto.Checked)
            {
                if (String.IsNullOrEmpty(txtCPF.Text))
                    errorProviderRlt.SetError(txtCPF, "Informe o número do CPF.");

                if (dtDataIni.Value > dtDataFim.Value)
                    errorProviderRlt.SetError(dtDataFim, "A data inicial não pode ser maior que a data final.");
            }else
                if (rbFuncionarioEmpresa.Checked)
            {
                if (String.IsNullOrEmpty(txtCNPJ.Text))
                    errorProviderRlt.SetError(txtCNPJ, "Informe o número do CNPJ.");
            }

            return ((errorProviderRlt.GetError(txtCPF) == "") &&
                (errorProviderRlt.GetError(txtCNPJ) == "") &&
                (errorProviderRlt.GetError(dtDataFim) == ""));
        }

        public void LimparTela()
        {
            txtCPF.Text = "";
            txtCNPJ.Text = "";
        }
        public void limparErros()
        {
            errorProviderRlt.SetError(txtCPF, "");
            errorProviderRlt.SetError(dtDataFim, "");
            errorProviderRlt.SetError(txtCNPJ, "");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (rbPonto.Checked)
            {
                if (txtCPF.Text.Length == 11)
                {
                    long CPF = Convert.ToInt64(txtCPF.Text);
                    string CPFFormatado = String.Format(@"{0:000\.000\.000\-00}", CPF);
                    txtCPF.Text = CPFFormatado;
                }
            }
            else
                if (rbFuncionarioEmpresa.Checked)
            {
                if (txtCPF.Text.Length == 14)
                {
                    long CNPJ = Convert.ToInt64(txtCNPJ.Text);
                    string CNPJFormatado = String.Format(@"{0:00\.000\.000\/0000\-00}", CNPJ);
                    txtCPF.Text = CNPJFormatado;
                }
            }

            limparErros();
            Confirmar();
        }

        public void Confirmar()
        {
            if (Validar())
            {
                if (rbPonto.Checked)
                {
                    if (txtCPF.Text.Length == 11)
                    {
                        long CPF = Convert.ToInt64(txtCPF.Text);
                        string CPFFormatado = String.Format(@"{0:000\.000\.000\-00}", CPF);
                        txtCPF.Text = CPFFormatado;
                    }

                    DateTime dataIni = dtDataIni.Value.Date;
                    DateTime dataFim = dtDataFim.Value.Date;

                    frmRltFuncionario janela = new frmRltFuncionario(context, txtCPF.Text, dtDataIni.Value, dtDataFim.Value);
                    janela.Show();
                }else
                    if (rbFuncionarioEmpresa.Checked)
                    {
                        if (txtCNPJ.Text.Length == 14)
                        {
                            long CNPJ = Convert.ToInt64(txtCNPJ.Text);
                            string CNPJFormatado = String.Format(@"{0:00\.000\.000\/0000\-00}", CNPJ);
                            txtCPF.Text = CNPJFormatado;
                        }

                        frmRltFuncionarioEmpresa janela = new frmRltFuncionarioEmpresa(context, txtCNPJ.Text);
                        janela.Show();
                    }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCPF_Leave_1(object sender, EventArgs e)
        {
            servico = new FuncionarioService(context);
            bool CPFexiste = false;

            limparErros();

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

                if (!CPFexiste)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Esse CPF não existe cadastrado no sistema no sistema.", "Atenção!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                    LimparTela();
                    txtCPF.Focus();
                    return;
                }
            }
        }

        private void rbFuncionarioEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            gbPonto.Visible = false;
            gbFuncionarioEmpresa.Visible = true;
        }

        private void rbPonto_CheckedChanged(object sender, EventArgs e)
        {
            gbPonto.Visible = true;
            gbFuncionarioEmpresa.Visible = false;
        }
    }
}

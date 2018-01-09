using LabxPonto_Commons;
using LabxPonto_Commons.WebService;
using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
using LabxPonto_View.Enums;
using LabxPonto_View.Views.Base;
using MetroFramework.Controls;
using System;
using System.Windows.Forms;

namespace LabxPonto_View.Views.Empresas
{
    public partial class frmEmpresaCadastro : frmBaseCadastro
    {
        private Operacao operacao;
        private EmpresaService servico;
        private ValidateCPF_CNPJ validate;
        private Endereco endereco;
        protected Empresa empresa;
        protected string caminhoImagem;

        public Empresa Empresa
        {
            get { return (empresa); }
            set { empresa = value; }
        }

        public bool validar()
        {
            #region DADOS DA EMPRESA

            if (String.IsNullOrEmpty(txtFolha.Text))
                errorProviderEmp.SetError(txtFolha, "Informe o número da folha");

            if (String.IsNullOrEmpty(txtNomeEmpresa.Text))
                errorProviderEmp.SetError(txtNomeEmpresa, "Informe o nome da empresa");

            if (String.IsNullOrEmpty(txtCNPJ.Text))
                errorProviderEmp.SetError(txtCNPJ, "Informe o CNPJ da empresa.");
            else
                if (!validate.ValidarCPF_CNPJ(txtCNPJ.Text))
                    errorProviderEmp.SetError(txtCNPJ, "O CNPJ informado é inválido.");

            if (String.IsNullOrEmpty(txtInscricao.Text))
                errorProviderEmp.SetError(txtInscricao, "Informe a inscrção da empresa");

            if (String.IsNullOrEmpty(txtNomeResponsavel.Text))
                errorProviderEmp.SetError(txtNomeResponsavel, "Informe o nome do responsável da empresa");

            if (String.IsNullOrEmpty(txtCargoResponsavel.Text))
                errorProviderEmp.SetError(txtCargoResponsavel, "Informe o cargo do responsável da empresa");

            if (String.IsNullOrEmpty(txtEmailResponsavel.Text))
                errorProviderEmp.SetError(txtEmailResponsavel, "Informe o email do responsável da empresa");

            #endregion

            #region DADOS ENDEREÇO

            if (String.IsNullOrEmpty(txtCEP.Text))
                errorProviderEmp.SetError(txtCEP, "Informe o CEP da empresa");

            if (String.IsNullOrEmpty(txtCidade.Text))
                errorProviderEmp.SetError(txtCidade, "Informe a cidade da empresa.");

            if (String.IsNullOrEmpty(txtBairro.Text))
                errorProviderEmp.SetError(txtBairro, "Informe o bairro da empresa.");

            if (String.IsNullOrEmpty(txtComplemento.Text))
                errorProviderEmp.SetError(txtComplemento, "Informe um complemento do endereço da empresa.");

            #endregion

            return ((errorProviderEmp.GetError(txtFolha) == "") &&
                (errorProviderEmp.GetError(txtNomeEmpresa) == "") &&
                (errorProviderEmp.GetError(txtInscricao) == "") &&
                (errorProviderEmp.GetError(txtCNPJ) == "") &&
                (errorProviderEmp.GetError(txtNomeResponsavel) == "") &&
                (errorProviderEmp.GetError(txtCargoResponsavel) == "") &&
                (errorProviderEmp.GetError(txtEmailResponsavel) == "") &&
                (errorProviderEmp.GetError(txtCEP) == "") &&
                (errorProviderEmp.GetError(txtCidade) == "") &&
                (errorProviderEmp.GetError(txtBairro) == "") &&
                (errorProviderEmp.GetError(txtComplemento) == ""));
        }

        public void limparTela()
        {
            txtBairro.Text = "";
            txtCEP.Text = "";
            txtCidade.Text = "";
            txtComplemento.Text = "";
            txtCNPJ.Text = "";
            txtEndereco.Text = "";
            txtFolha.Text = "";
            txtNomeEmpresa.Text = "";
            txtInscricao.Text = "";
            txtNomeResponsavel.Text = "";
            txtEmailResponsavel.Text = "";
            txtCargoResponsavel.Text = "";
        }

        public void limparErros()
        {
            errorProviderEmp.SetError(txtFolha, "");
            errorProviderEmp.SetError(txtNomeEmpresa, "");
            errorProviderEmp.SetError(txtCNPJ, "");
            errorProviderEmp.SetError(txtInscricao, "");
            errorProviderEmp.SetError(txtNomeResponsavel, "");
            errorProviderEmp.SetError(txtCargoResponsavel, "");
            errorProviderEmp.SetError(txtEmailResponsavel, "");
            errorProviderEmp.SetError(txtCEP, "");
            errorProviderEmp.SetError(txtCidade, "");
            errorProviderEmp.SetError(txtBairro, "");
            errorProviderEmp.SetError(txtComplemento, "");
        }

        public void preencherTela()
        {
            txtNomeEmpresa.Text = empresa.NomeFantasia;
            txtFolha.Text = empresa.NumeroFolha.ToString();
            txtCNPJ.Text = empresa.CNPJ;
            txtInscricao.Text = empresa.Inscricao;
            txtNomeResponsavel.Text = empresa.NomeResponsavel;
            txtCargoResponsavel.Text = empresa.CargoResponsavel;
            txtEmailResponsavel.Text = empresa.EmailResponsavel;

            txtEndereco.Text = empresa.Endereco.Logradouro;
            txtBairro.Text = empresa.Endereco.Bairro;
            txtCidade.Text = empresa.Endereco.Cidade;
            cmbEstado.Text = empresa.Endereco.Estado;
            txtComplemento.Text = empresa.Endereco.Complemento;
            txtCEP.Text = empresa.Endereco.Cep.ToString();

            if (operacao == Operacao.Visualizar)
            {
                txtNomeEmpresa.ReadOnly = true;
                txtFolha.ReadOnly = true;
                txtCNPJ.ReadOnly = true;
                txtInscricao.ReadOnly = true;
                txtNomeResponsavel.ReadOnly = true;
                txtCargoResponsavel.ReadOnly = true;
                txtEmailResponsavel.ReadOnly = true;

                txtEndereco.ReadOnly = true;
                txtBairro.ReadOnly = true;
                txtCidade.ReadOnly = true;
                txtComplemento.ReadOnly = true;
                txtCEP.ReadOnly = true;
            }
        }

        public void preencherEmpresa()
        {
            empresa.NomeFantasia = txtNomeEmpresa.Text;
            empresa.NumeroFolha = Convert.ToInt32(txtFolha.Text);
            empresa.CNPJ = txtCNPJ.Text;
            empresa.Inscricao = txtInscricao.Text;
            empresa.NomeResponsavel = txtNomeResponsavel.Text;
            empresa.CargoResponsavel = txtCargoResponsavel.Text;
            empresa.EmailResponsavel = txtEmailResponsavel.Text;

            empresa.Endereco.Logradouro = txtEndereco.Text;
            empresa.Endereco.Bairro = txtBairro.Text;
            empresa.Endereco.Cidade = txtCidade.Text;
            empresa.Endereco.Estado = cmbEstado.Text;
            empresa.Endereco.Complemento = txtComplemento.Text;

            if (!String.IsNullOrEmpty(txtCEP.Text))
                empresa.Endereco.Cep = Convert.ToInt32(txtCEP.Text);
        }

        private void inserir()
        {
            if (validar())
            {
                preencherEmpresa();
                if (servico.Insert(empresa))
                {
                    MetroFramework.MetroMessageBox.Show(this, "A Empresa " + empresa.NomeFantasia + " foi cadastrada no sistema com sucesso!", "Cadastrado com sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
                    limparTela();
                }
            }
        }

        private void excluir()
        {
            limparErros();
            if (validar())
            {
                preencherEmpresa();
                if (servico.Delete(empresa))
                {
                    MetroFramework.MetroMessageBox.Show(this, "A empresa " + empresa.NomeFantasia + " foi deletada com sucesso!", "Excluído com sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
                    this.Dispose();
                }
            }
        }

        private void editar()
        {
            limparErros();
            if (validar())
            {
                preencherEmpresa();
                if (servico.Update(empresa))
                {
                    MetroFramework.MetroMessageBox.Show(this, "A empresa " + empresa.NomeFantasia + " foi alterada com sucesso!", "Alterado com sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
                    this.Dispose();
                }
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void frmFuncionarioCadastro_Load(object sender, EventArgs e)
        {
            preencherCombos(cmbEstado);

            if (operacao == Operacao.Inserir)
            {
                empresa.Endereco = new Endereco();
                empresa.Imagem = new Imagem();
            }
            preencherTela();
        }

        private void preencherCombos(MetroComboBox parNomeCombo)
        {
            switch (parNomeCombo.Name)
            {
                case "cmbEstado":
                    cmbEstado.DataSource = Enum.GetNames(typeof(Estados));
                    break;
                case "cmbPais":
                    //cmbEstado.DataSource = Enum.GetNames(typeof(Estados));
                    break;
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtFolha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        public frmEmpresaCadastro(Operacao _operacao, AppDataContext con)
        {
            InitializeComponent();
            operacao = _operacao;
            servico = new EmpresaService(con);
            validate = new ValidateCPF_CNPJ();
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            switch (operacao)
            {
                case Operacao.Inserir:
                    inserir();
                    break;
                case Operacao.Excluir:
                    excluir();
                    break;
                case Operacao.Editar:
                    editar();
                    break;
            }
        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            if (txtCNPJ.Text.Length == 14)
            {
                long CNPJ = Convert.ToInt64(txtCNPJ.Text);
                string CNPJFormatado = String.Format(@"{0:\00\.000\.000/0000-00}", CNPJ);
                txtCNPJ.Text = CNPJFormatado;
            }
        }

        private void frmEmpresaCadastro_Load(object sender, EventArgs e)
        {
            if (operacao == Operacao.Inserir)
                empresa.Endereco = new Endereco();
        }

        private void btnCancelar_Click_2(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                if (!String.IsNullOrEmpty(txtCEP.Text))
                {
                    endereco = new Endereco();
                    CEPCorreios cepCorreios = new CEPCorreios();
                    cepCorreios.preencheEndereco(txtCEP.Text);

                    txtBairro.Text = endereco.Bairro;
                    txtCidade.Text = endereco.Cidade;
                    txtEndereco.Text = endereco.Logradouro;
                    txtComplemento.Text = endereco.Complemento;
                    cmbEstado.Text = endereco.Estado;
                }
            }
        }
    }
}

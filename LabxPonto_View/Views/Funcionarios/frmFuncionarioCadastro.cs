using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
using LabxPonto_View.Enums;
using LabxPonto_View.Views.Base;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabxPonto_View.Views.Funcionarios
{
    public partial class frmFuncionarioCadastro : frmBaseCadastro
    {
        private Operacao operacao;
        private FuncionarioService servico;
        protected Funcionario funcionario;

        public Funcionario Funcionario
        {
            get { return (funcionario); }
            set { funcionario = value; }
        }

        public bool validar()
        {
            return true;
        }

        public frmFuncionarioCadastro(Operacao _operacao)
        {
            InitializeComponent();
            operacao = _operacao;
            servico = new FuncionarioService();
        }

        public void limparTela()
        {
            
            txtBairro.Text = "";
            txtCEP.Text = "";
            txtCidade.Text = "";
            txtComplemento.Text = "";
            txtCPF.Text = "";
            txtEndereco.Text = "";
            txtFolha.Text = "";
            txtNomeFuncionario.Text = "";
            txtNomeMae.Text = "";
            txtNomePai.Text = "";
            txtRG.Text = "";
            txtSobreNome.Text = "";
            txtTelefone.Text = "";
        }
    
        public void preencherTela()
        {
            txtNomeFuncionario.Text = funcionario.Nome;
            txtSobreNome.Text = funcionario.SobreNome;
            txtCPF.Text = funcionario.CPF;
            txtRG.Text = funcionario.RG;
            if(funcionario.DataNascimento > DateTime.MinValue)
                dtDataNascimento.Value = funcionario.DataNascimento;
            // TODO: funcionario.Digital
            // TODO: funcionario.Empresa = cmbEmpresa
            txtBairro.Text = funcionario.Endereco.Bairro;
             txtCEP.Text = funcionario.Endereco.Cep.ToString();
            txtCidade.Text = funcionario.Endereco.Cidade;
            txtComplemento.Text = funcionario.Endereco.Complemento;
            if(funcionario.Endereco.Estado != null)
                cmbEstado.SelectedText = funcionario.Endereco.Estado.ToString();
            cmbEstadoCivil.Text = funcionario.EstadoCivil;
            // TODO: funcionario.Funcao = 
            txtNomeMae.Text = funcionario.NomeMae;
            txtNomePai.Text = funcionario.NomePai;
            txtTelefone.Text = funcionario.Telefone;
            
        }

        public void preencherFuncionario()
        {
            funcionario.Nome = txtNomeFuncionario.Text;
            funcionario.SobreNome = txtSobreNome.Text;
            funcionario.CPF = txtCPF.Text;
            funcionario.RG = txtRG.Text;
            funcionario.DataNascimento = dtDataNascimento.Value;
            // TODO: funcionario.Digital
            // TODO: funcionario.Empresa = cmbEmpresa
            funcionario.Endereco.Bairro = txtBairro.Text;
            if (!String.IsNullOrEmpty(txtCEP.Text))
                funcionario.Endereco.Cep = Convert.ToInt32(txtCEP.Text);
            funcionario.Endereco.Cidade = txtCidade.Text;
            funcionario.Endereco.Complemento = txtComplemento.Text;
            funcionario.Endereco.Estado = cmbEstado.Text;
            funcionario.EstadoCivil = cmbEstadoCivil.Text;
            // TODO: funcionario.Funcao = 
            funcionario.NomeMae = txtNomeMae.Text;
            funcionario.NomePai = txtNomePai.Text;
            funcionario.Telefone = txtTelefone.Text;
        }


        private void inserir()
        {
            if (validar())
            {
                preencherFuncionario();
                if (servico.Insert(funcionario))
                {
                    MetroFramework.MetroMessageBox.Show(this, "O funcionário " + funcionario.Nome + " "+ funcionario.SobreNome +" foi cadastrado no sistema com sucesso!", "Cadastrado com sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
                    limparTela();
                }
            }
        }

        private void excluir()
        {
            //if (servico.Delete(departamento))
            //{
            //    MetroFramework.MetroMessageBox.Show(this, "O departamento " + departamento.NomeDepartamento + " foi deletado do sistema com sucesso!", "Cadastrado com sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
            //    this.Dispose();
            //}
        }

        private void editar()
        {
            //if (validar())
            //{
            //    preencherDepartamento();
            //    if (servico.Update(departamento))
            //    {
            //        MetroFramework.MetroMessageBox.Show(this, "O departamento " + departamento.NomeDepartamento + " foi alterado com sucesso!", "Cadastrado com sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
            //        this.Dispose();
            //    }
            //}
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }
        
        private void frmFuncionarioCadastro_Load(object sender, EventArgs e)
        {
            preencherCombos(cmbEstado);
            preencherCombos(cmbEstadoCivil);
            if(operacao == Operacao.Inserir)
            {
                funcionario.Empresa = new Empresa();
                funcionario.Endereco = new Endereco();
                funcionario.Funcao = new Funcao();
                funcionario.Imagem = new Imagem();
            }
            preencherTela();
        }

        private void preencherCombos(MetroComboBox parNomeCombo)
        {
            switch(parNomeCombo.Name)
            {
                case "cmbEstado":
                    cmbEstado.DataSource = Enum.GetNames(typeof(Estados));
                    break;
                case "cmbEstadoCivil":
                    cmbEstadoCivil.DataSource = Enum.GetNames(typeof(EstadoCivil));
                    break;
            }
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

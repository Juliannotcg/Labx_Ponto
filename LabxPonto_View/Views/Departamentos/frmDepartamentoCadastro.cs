using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
using LabxPonto_View.Enums;
using LabxPonto_View.Views.Base;
using System;

namespace LabxPonto_View.Views.Departamentos
{
    public partial class frmDepartamentoCadastro : frmBaseCadastro
    {
        private Operacao operacao;
        private DepartamentoService servico;
        protected Departamento departamento;

        public Departamento Departamento
        {
            get { return (departamento); }
            set { departamento = value; }
        }

        public bool validar()
        {
            if (String.IsNullOrEmpty(txtNomeDepartamento.Text))
            {
                errorProviderDep.SetError(txtNomeDepartamento, "Informe a descreição do departamento.");
                return false;
            }
            if (String.IsNullOrEmpty(txtDescricaoDepartamento.Text))
            {
                errorProviderDep.SetError(txtDescricaoDepartamento, "Informe a descrição do departamento.");
                return false;
            }
                return true;
        }

        public void limparTela()
        {
            txtDescricaoDepartamento.Text = "";
            txtNomeDepartamento.Text = "";
        }

        public void preencherTela()
        {
            txtDescricaoDepartamento.Text = departamento.Descricao;
            txtNomeDepartamento.Text = departamento.NomeDepartamento;

            if(operacao == Operacao.Excluir)
            {
                txtDescricaoDepartamento.ReadOnly = true;
                txtNomeDepartamento.ReadOnly = true;
            }
        }

        public frmDepartamentoCadastro(Operacao _operacao, AppDataContext con)
        {
            InitializeComponent();
            operacao = _operacao;
            servico = new DepartamentoService(con);
        }

        public void preencherDepartamento()
        {
            departamento.NomeDepartamento = txtNomeDepartamento.Text;
            departamento.Descricao = txtDescricaoDepartamento.Text;
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

        private void inserir()
        {
            if (validar())
            {
                preencherDepartamento();
                if (servico.Insert(departamento))
                {
                    MetroFramework.MetroMessageBox.Show(this, "O departamento " + departamento.NomeDepartamento + " foi cadastrado no sistema com sucesso!", "Cadastrado com sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
                    limparTela();
                }
            }
        }

        private void excluir()
        {
            if (servico.Delete(departamento))
            {
                MetroFramework.MetroMessageBox.Show(this, "O departamento " + departamento.NomeDepartamento + " foi deletado do sistema com sucesso!", "Cadastrado com sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
                this.Dispose();
            }
        }

        private void editar()
        {
            if (validar())
            {
                preencherDepartamento();
                if (servico.Update(departamento))
                {
                    MetroFramework.MetroMessageBox.Show(this, "O departamento " + departamento.NomeDepartamento + " foi alterado com sucesso!", "Cadastrado com sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
                    this.Dispose();
                }
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void frmDepartamentoCadastro_Load(object sender, System.EventArgs e)
        {
            preencherTela();
        }
    }
}

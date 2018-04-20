using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
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

namespace LabxPonto_View.Views.Funções
{
    public partial class frmFuncaoCadastro : frmBaseCadastro
    {
        private Operacao operacao;
        private FuncaoService servico;
        protected Function funcao;
        private AppDataContext context;

        public Function Funcao
        {
            get { return (funcao); }
            set { funcao = value; }
        }

        public bool validar()
        {
            if (String.IsNullOrEmpty(txtNomeFuncao.Text))
                errorProviderFun.SetError(txtNomeFuncao, "Informe o nome da função.");

            if (String.IsNullOrEmpty(txtDescricaoFuncao.Text))
                errorProviderFun.SetError(txtDescricaoFuncao, "Informe a descrição da função.");

            return ((errorProviderFun.GetError(txtNomeFuncao) == "") &&
                (errorProviderFun.GetError(txtDescricaoFuncao) == ""));
        }

        public void limparTela()
        {
            txtDescricaoFuncao.Text = "";
            txtNomeFuncao.Text = "";
        }

        public void limparErros()
        {
            errorProviderFun.SetError(txtNomeFuncao, "");
            errorProviderFun.SetError(txtDescricaoFuncao, "");
        }

        public void preencherTela()
        {
            txtDescricaoFuncao.Text = funcao.Description;
            txtNomeFuncao.Text = funcao.NameFunction;
            if(funcao.Department!=null)
                cbDepartamento.Text = funcao.Department.NameDepartment;

            if (operacao == Operacao.Excluir ||
                operacao == Operacao.Visualizar)
            {
                txtDescricaoFuncao.ReadOnly = true;
                txtNomeFuncao.ReadOnly = true;
                cbDepartamento.Enabled = false;
            }
        }

        public frmFuncaoCadastro(Operacao _operacao, AppDataContext con)
        {
            InitializeComponent();
            operacao = _operacao;
            servico = new FuncaoService(con);
            context = con;
        }

        public void preencherFuncao()
        {
            funcao.NameFunction = txtNomeFuncao.Text;
            funcao.Description = txtDescricaoFuncao.Text;
            funcao.Department = (Department)cbDepartamento.SelectedItem;
        }

        private void inserir()
        {
            if (validar())
            {
                preencherFuncao();
                if (servico.Insert(funcao))
                {
                    MetroFramework.MetroMessageBox.Show(this, "A Função " + funcao.NameFunction + " foi cadastrada no sistema com sucesso!", "Cadastrada com sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
                    limparTela();
                }
            }
        }

        private void excluir()
        {
            if (servico.Delete(funcao))
            {
                MetroFramework.MetroMessageBox.Show(this, "A Função " + funcao.NameFunction + " foi deletada do sistema com sucesso!", "Cadastrado com sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
                this.Dispose();
            }
        }

        private void editar()
        {
            if (validar())
            {
                preencherFuncao();
                if (servico.Update(funcao))
                {
                    MetroFramework.MetroMessageBox.Show(this, "A Função " + funcao.NameFunction + " foi alterada com sucesso!", "Alterada com sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
                    this.Dispose();
                }
            }
        }

        private void frmFuncaoCadastro_Load(object sender, EventArgs e)
        {
            DepartamentoService depService = new DepartamentoService(context);
            cbDepartamento.DataSource = depService.GetDepartamento();
            cbDepartamento.ValueMember = "Id";
            cbDepartamento.DisplayMember = "NomeDepartamento"; 
            preencherTela();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            limparErros();

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

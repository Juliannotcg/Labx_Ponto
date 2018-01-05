using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
using LabxPonto_View.Enums;
using LabxPonto_View.Views.Base;
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
           
        }

        public void preencherTela()
        {
           
        }

        public void preencherDepartamento()
        {
            
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
            //if (validar())
            //{
            //    preencherDepartamento();
            //    if (servico.Insert(funcionario))
            //    {
            //        MetroFramework.MetroMessageBox.Show(this, "O departamento " + departamento.NomeDepartamento + " foi cadastrado no sistema com sucesso!", "Cadastrado com sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
            //        limparTela();
            //    }
            //}
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
            preencherTela();
        }
    }
}

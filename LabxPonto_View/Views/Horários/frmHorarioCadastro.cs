using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
using LabxPonto_View.Enums;
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

namespace LabxPonto_View.Views.Horários
{
    public partial class frmHorarioCadastro : MetroForm
    {
        private Operacao operacao;
        private Funcionario funcionario;
        private HorarioService servico;
        protected HorarioExpediente horarioExpediente;

        public frmHorarioCadastro(Operacao _operacao, AppDataContext con, Funcionario _funcionario)
        {
            InitializeComponent();
            operacao = _operacao;
            funcionario = _funcionario;
            servico = new HorarioService(con);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
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
       
        public HorarioExpediente HorarioExpediente
        {
            get { return (horarioExpediente); }
            set { horarioExpediente = value; }
        }

        public bool validar()
        {

            if (String.IsNullOrEmpty(txtEntrada.Text))
                errorProviderHor.SetError(txtEntrada, "Informe um horário de entrada.");

            if (String.IsNullOrEmpty(txtSaida.Text))
                errorProviderHor.SetError(txtSaida, "Informe um horário de saída.");

            return ((errorProviderHor.GetError(txtEntrada) == "") &&
                (errorProviderHor.GetError(txtSaida) == ""));
        }

        public void limparTela()
        {
            txtEntrada.Text = "";
            txtSaida.Text = "";
        }

        public void limparErros()
        {
            errorProviderHor.SetError(txtEntrada, "");
            errorProviderHor.SetError(txtSaida, "");
        }

        public void preencherTela()
        {
            dpData.Value = horarioExpediente.Data;
            txtEntrada.Text = Convert.ToString(horarioExpediente.Entrada);
            txtSaida.Text = Convert.ToString(horarioExpediente.Saida);

            if (operacao == Operacao.Excluir ||
                operacao == Operacao.Visualizar)
            {
                txtEntrada.ReadOnly = true;
                txtSaida.ReadOnly = true;
            }
        }

        public void PreencherHorario()
        {
            horarioExpediente.Data = dpData.Value;
            horarioExpediente.Entrada = Convert.ToDateTime(txtEntrada.Text);
            horarioExpediente.Saida = Convert.ToDateTime(txtSaida.Text);
            horarioExpediente.Funcionario = funcionario;
        }

        private void inserir()
        {
            if (validar())
            {
                PreencherHorario();
                if (servico.Insert(horarioExpediente))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Foi inserido o horário de entrada: " + horarioExpediente.Entrada + " e de saída: " + horarioExpediente.Saida +
                        " no funcionário: " + horarioExpediente.Funcionario.Nome + ".", "Cadastrado com sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
                    limparTela();
                    this.Dispose();
                }
            }
        }

        private void excluir()
        {
            if (servico.Delete(horarioExpediente))
            {
                MetroFramework.MetroMessageBox.Show(this, "Foi excluído os horário da data: " + horarioExpediente.Data + " do funcionário: " + horarioExpediente.Funcionario.Nome + ".", "Excluído com sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
                this.Dispose();
            }
        }

        private void editar()
        {
            if (validar())
            {
                PreencherHorario();
                if (servico.Update(horarioExpediente))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Foi alterado o horário de entrada: " + horarioExpediente.Entrada + " e de saída: " + horarioExpediente.Saida +
                        " no funcionário: " + horarioExpediente.Funcionario.Nome + ".", "Alterado com sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
                    this.Dispose();
                }
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmHorarioCadastro_Load(object sender, EventArgs e)
        {
            preencherTela();
        }
    }
}

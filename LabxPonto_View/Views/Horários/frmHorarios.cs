using LabxPonto_Commons;
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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabxPonto_View.Views.Horários
{
    public partial class frmHorarios : MetroForm
    {
        private ValidateCPF_CNPJ validate;
        private AppDataContext context;
        private Funcionario funcionario;
        private HorarioService servico;
        private frmHorarioCadastro cadastro;
        private HorarioExpediente horarioExpediente;

        public frmHorarios(AppDataContext con)
        {
            InitializeComponent();
            txtCPF.CustomButton.Click += new EventHandler(txtCPF_Click);
            validate = new ValidateCPF_CNPJ();
            context = con;
            funcionario = new Funcionario();
            servico = new HorarioService(context);
            horarioExpediente = new HorarioExpediente();
        }

        private void frmHorarios_Load(object sender, EventArgs e)
        {
        }
        public void PreencherGrid()
        {
            DateTime dataIni = dpDataInicial.Value.Date;
            DateTime dataFim = dpDataInicial.Value.Date;

            dgFuncionarios.DataSource = servico.GetHorarioFuncionarioCPF(txtCPF.Text, dataIni, dataFim);
        }

        public bool validar()
        {
            if (!validate.ValidarCPF_CNPJ(txtCPF.Text))
                errorProviderFunc.SetError(txtCPF, "O CPF informado é inválido.");

            return true;
        }
        public void limparErros()
        {
            errorProviderFunc.SetError(txtCPF, "");
        }

        private void txtCPF_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (txtCPF.Text.Length == 11)
                {
                    long CPF = Convert.ToInt64(txtCPF.Text);
                    string CPFFormatado = String.Format(@"{0:000\.000\.000\-00}", CPF);
                    txtCPF.Text = CPFFormatado;
                }

                FuncionarioService funServ = new FuncionarioService(context);
                funcionario = funServ.GetFuncionarioCPF(txtCPF.Text);

                if (funcionario != null)
                {
                    txtNome.Text = funcionario.Nome + " " + funcionario.SobreNome;
                    if(funcionario.Empresa!=null)
                        txtEmpresa.Text = funcionario.Empresa.NomeFantasia;
                    if(funcionario.Funcao!=null)
                        txtFuncao.Text = funcionario.Funcao.NomeFuncao;
                    if(funcionario.Funcao.Departamento != null)
                        txtDepartamento.Text = funcionario.Funcao.Departamento.NomeDepartamento;

                    if (funcionario.Imagem != null)
                        if (funcionario.Imagem.Arquivo != null)
                        {
                            preencherImagemByte(funcionario.Imagem.Arquivo);
                        }
                    PreencherGrid();

                    btNovo.Visible = true;
                    btAlterar.Visible = true;
                    btExcluir.Visible = true;
                }
            }
        }

        public void preencherImagemByte(byte[] imagemEmBytes)
        {
            MemoryStream ms = new MemoryStream();
            Image img;

            try
            {
                ms = new MemoryStream(imagemEmBytes, 0, imagemEmBytes.Length);
                ms.Write(imagemEmBytes, 0, imagemEmBytes.Length);
                img = Image.FromStream(ms, true);
                imgFoto.Image = img;
            }
            catch (ArgumentException aex)
            {
                throw new InvalidOperationException("Imagem inválida");
            }
            finally
            {
                if (ms != null)
                {
                    ms.Close();
                    ms = null;
                }
            }
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (txtCPF.Text.Length == 11)
            {
                long CPF = Convert.ToInt64(txtCPF.Text);
                string CPFFormatado = String.Format(@"{0:000\.000\.000\-00}", CPF);
                txtCPF.Text = CPFFormatado;
            }
        }

        public HorarioExpediente retornarHorarioSelecionado()
        {
            horarioExpediente = new HorarioExpediente();
            horarioExpediente.Id = (int)dgFuncionarios.Rows[dgFuncionarios.CurrentRow.Index].Cells["Id"].Value;
            horarioExpediente = servico.GetHorario(horarioExpediente.Id);
            return horarioExpediente;
        }

        private void btNovo_Click_1(object sender, EventArgs e)
        {
            cadastro = new frmHorarioCadastro(Operacao.Inserir, context, funcionario);
            cadastro.StyleManager = this.StyleManager;
            cadastro.HorarioExpediente = new HorarioExpediente();
            cadastro.ShowDialog();
            PreencherGrid();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            cadastro = new frmHorarioCadastro(Operacao.Editar, context, funcionario);
            cadastro.StyleManager = this.StyleManager;
            cadastro.HorarioExpediente = retornarHorarioSelecionado();
            cadastro.ShowDialog();
            PreencherGrid();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            cadastro = new frmHorarioCadastro(Operacao.Excluir, context, funcionario);
            cadastro.StyleManager = this.StyleManager;
            cadastro.HorarioExpediente = retornarHorarioSelecionado();
            cadastro.ShowDialog();
            PreencherGrid();
        }
    }
}

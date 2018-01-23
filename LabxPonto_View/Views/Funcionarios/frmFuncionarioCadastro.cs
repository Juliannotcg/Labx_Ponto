using LabxPonto_Commons;
using LabxPonto_Commons.WebService;
using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
using LabxPonto_View.Enums;
using LabxPonto_View.Views.Base;
using LabxPonto_View.Views.Cam;
using MetroFramework.Controls;
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

namespace LabxPonto_View.Views.Funcionarios
{
    public partial class frmFuncionarioCadastro : frmBaseCadastro
    {
        private Operacao operacao;
        private FuncionarioService servico;
        private ValidateCPF_CNPJ validate;
        protected Funcionario funcionario;
        protected string caminhoImagem;
        private AppDataContext context;
        byte[] imagemByte;

        public Funcionario Funcionario
        {
            get { return (funcionario); }
            set { funcionario = value; }
        }

        public bool validar()
        {
            #region DADOS PESSOAIS

            if (String.IsNullOrEmpty(txtFolha.Text))
                errorProviderFunc.SetError(txtFolha, "Informe o número da folha");

            if (String.IsNullOrEmpty(txtLocalTrabalho.Text))
                errorProviderFunc.SetError(txtLocalTrabalho, "Informe o local de trabalho");

            if (String.IsNullOrEmpty(txtNomeFuncionario.Text))
                errorProviderFunc.SetError(txtNomeFuncionario, "Informe o nome do funcionário.");

            if (String.IsNullOrEmpty(txtSobreNome.Text))
                errorProviderFunc.SetError(txtSobreNome, "Informe o sobre nome do funcionário.");

            if (String.IsNullOrEmpty(txtCPF.Text))
                errorProviderFunc.SetError(txtCPF, "Informe o sobre nome do funcionário.");
            else
                if (!validate.ValidarCPF_CNPJ(txtCPF.Text))
                errorProviderFunc.SetError(txtCPF, "O CPF informado é inválido.");

            if (String.IsNullOrEmpty(txtRG.Text))
                errorProviderFunc.SetError(txtRG, "Informe o RG do funcionário.");

            if (String.IsNullOrEmpty(txtTelefone.Text))
                errorProviderFunc.SetError(txtTelefone, "Informe o telefone do funcionário.");

            if (String.IsNullOrEmpty(txtNomePai.Text))
                errorProviderFunc.SetError(txtNomePai, "Informe o nome do Pai do funcionário.");

            if (String.IsNullOrEmpty(txtNomeMae.Text))
                errorProviderFunc.SetError(txtNomeMae, "Informe o nome da Mãe do funcionário.");

            #endregion

            #region DADOS ENDEREÇO

            if (String.IsNullOrEmpty(txtCEP.Text))
                errorProviderFunc.SetError(txtCEP, "Informe o CEP do funcionário");

            if (String.IsNullOrEmpty(txtCidade.Text))
                errorProviderFunc.SetError(txtCidade, "Informe a cidade do funcionário.");

            if (String.IsNullOrEmpty(txtBairro.Text))
                errorProviderFunc.SetError(txtBairro, "Informe o bairro do funcionário.");

            if (String.IsNullOrEmpty(txtEndereco.Text))
                errorProviderFunc.SetError(txtEndereco, "Informe o endereço do funcionário.");
            #endregion

            return ((errorProviderFunc.GetError(txtFolha) == "") &&
                (errorProviderFunc.GetError(txtNomeFuncionario) == "") &&
                (errorProviderFunc.GetError(txtSobreNome) == "") &&
                (errorProviderFunc.GetError(txtCPF) == "") &&
                (errorProviderFunc.GetError(txtRG) == "") &&
                (errorProviderFunc.GetError(txtNomePai) == "") &&
                (errorProviderFunc.GetError(txtNomeMae) == "") &&
                (errorProviderFunc.GetError(txtTelefone) == "") &&
                (errorProviderFunc.GetError(txtCEP) == "") &&
                (errorProviderFunc.GetError(txtCidade) == "") &&
                (errorProviderFunc.GetError(txtBairro) == "") &&
                (errorProviderFunc.GetError(txtLocalTrabalho) == "") &&
                (errorProviderFunc.GetError(txtEndereco) == ""));
        }

        public void limparErros()
        {
            errorProviderFunc.SetError(txtFolha, "");
            errorProviderFunc.SetError(txtNomeFuncionario, "");
            errorProviderFunc.SetError(txtSobreNome, "");
            errorProviderFunc.SetError(txtCPF, "");
            errorProviderFunc.SetError(txtRG, "");
            errorProviderFunc.SetError(txtNomePai, "");
            errorProviderFunc.SetError(txtNomeMae, "");
            errorProviderFunc.SetError(txtTelefone, "");
            errorProviderFunc.SetError(txtCEP, "");
            errorProviderFunc.SetError(txtCidade, "");
            errorProviderFunc.SetError(txtBairro, "");
            errorProviderFunc.SetError(txtEndereco, "");
            errorProviderFunc.SetError(txtLocalTrabalho, "");
        }

        public frmFuncionarioCadastro(Operacao _operacao, AppDataContext con)
        {
            InitializeComponent();
            operacao = _operacao;
            servico = new FuncionarioService(con);
            validate = new ValidateCPF_CNPJ();
            context = con;
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
            txtLocalTrabalho.Text = "";
        }

        public void preencherTela()
        {
            txtNomeFuncionario.Text = funcionario.Nome;
            txtSobreNome.Text = funcionario.SobreNome;
            txtCPF.Text = funcionario.CPF;
            txtRG.Text = funcionario.RG;
            if (funcionario.DataNascimento > DateTime.MinValue)
                txtDataNascimento.Text = funcionario.DataNascimento.ToString();

            txtFolha.Text = funcionario.NumeroFolha;
            if (funcionario.DataAdmissao > DateTime.MinValue)
                txtDataAdmissao.Text = funcionario.DataAdmissao.ToString();

            if (funcionario.Endereco != null)
            {
                txtEndereco.Text = funcionario.Endereco.Logradouro;
                txtBairro.Text = funcionario.Endereco.Bairro;
                txtCEP.Text = funcionario.Endereco.Cep.ToString();
                txtCidade.Text = funcionario.Endereco.Cidade;
                txtComplemento.Text = funcionario.Endereco.Complemento;
                if (funcionario.Endereco.Estado != null)
                    cmbEstado.SelectedText = funcionario.Endereco.Estado.ToString();
            }
            cmbEstadoCivil.Text = funcionario.EstadoCivil;
            if (funcionario.Funcao != null)
            {
                if (funcionario.Funcao.Departamento != null)
                {
                    cmbDepartamento.SelectedItem = funcionario.Funcao.Departamento;
                    cmbDepartamento.SelectedValue = funcionario.Funcao.Departamento.Id;
                }
                if (funcionario.Funcao != null)
                    cmbFuncao.SelectedItem = funcionario.Funcao;
            }

            if (funcionario.Empresa != null)
                cmbEmpresa.SelectedItem = funcionario.Empresa;

            txtNomeMae.Text = funcionario.NomeMae;
            txtNomePai.Text = funcionario.NomePai;
            txtTelefone.Text = funcionario.Telefone;
            txtLocalTrabalho.Text = funcionario.LocalTrabalho;
            if (funcionario.Imagem != null)
                if (funcionario.Imagem.Arquivo != null)
                {
                    preencherImagemByte(funcionario.Imagem.Arquivo);
                    imagemByte = funcionario.Imagem.Arquivo;
                }

            if ((operacao == Operacao.Visualizar)||
                (operacao == Operacao.Excluir))
            {
                txtNomeFuncionario.ReadOnly = true;
                txtSobreNome.ReadOnly = true;
                txtCPF.ReadOnly = true;
                txtRG.ReadOnly = true;
                txtDataNascimento.ReadOnly = true;

                txtFolha.ReadOnly = true;
                txtDataAdmissao.ReadOnly = true;
                txtEndereco.ReadOnly = true;
                txtBairro.ReadOnly = true;
                txtCEP.ReadOnly = true;
                txtCidade.ReadOnly = true;
                txtComplemento.ReadOnly = true;
                cmbEstado.Enabled = false;
                cmbEstadoCivil.Enabled = false;
                cmbDepartamento.Enabled = false;
                cmbFuncao.Enabled = false;
                cmbEmpresa.Enabled = false;

                txtNomeMae.ReadOnly = true;
                txtNomePai.ReadOnly = true;
                txtLocalTrabalho.ReadOnly = true;
                txtTelefone.ReadOnly = true;
                btCapturar.Enabled = false;
                btnLocalizarImg.Enabled = false;
            }
            if(operacao == Operacao.Visualizar)
            {
                btnSalvar.Visible = false;
                btnCancelar.Text = "Fechar";
            }

        }

        public void preencherFuncionario()
        {
            
            #region Contrato

            funcionario.NumeroFolha = txtFolha.Text;
            if (!String.IsNullOrEmpty(txtDataAdmissao.Text.Replace("/", "").Trim()))
                funcionario.DataAdmissao = Convert.ToDateTime(txtDataAdmissao.Text);

            #endregion

            #region Empresa
            funcionario.Empresa = new Empresa();
            funcionario.Empresa = (Empresa)cmbEmpresa.SelectedItem;

            #endregion

            #region Endereco

            funcionario.Endereco = new Endereco();
            funcionario.Endereco.Bairro = txtBairro.Text;
            if (!String.IsNullOrEmpty(txtCEP.Text))
                funcionario.Endereco.Cep = Convert.ToInt32(txtCEP.Text);
            funcionario.Endereco.Cidade = txtCidade.Text;
            funcionario.Endereco.Complemento = txtComplemento.Text;
            funcionario.Endereco.Estado = cmbEstado.Text;
            funcionario.Endereco.Logradouro = txtEndereco.Text;

            #endregion

            #region Função

            funcionario.Funcao = new Funcao();
            funcionario.Funcao = (Funcao)cmbFuncao.SelectedItem;

            #endregion

            #region Imagem

            funcionario.Imagem = new Imagem();
            if (imagemByte != null)
                funcionario.Imagem.Arquivo = imagemByte;
                //funcionario.Imagem.Arquivo = ConverterImagemParaBytes(imgFoto.ImageLocation);
                
            #endregion

            #region Funcionário 

            funcionario.Nome = txtNomeFuncionario.Text;
            funcionario.SobreNome = txtSobreNome.Text;
            funcionario.CPF = txtCPF.Text;
            funcionario.RG = txtRG.Text;
            if (!String.IsNullOrEmpty(txtDataNascimento.Text.Replace("/", "").Trim()))
                funcionario.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
            // TODO: funcionario.Digital
            funcionario.EstadoCivil = cmbEstadoCivil.Text;
            funcionario.NomeMae = txtNomeMae.Text;
            funcionario.NomePai = txtNomePai.Text;
            funcionario.Telefone = txtTelefone.Text;
            funcionario.LocalTrabalho = txtLocalTrabalho.Text;

            #endregion

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
            if (servico.Delete(funcionario))
            {
                MetroFramework.MetroMessageBox.Show(this, "O funcionário " + funcionario.Nome + " " + funcionario.SobreNome + " foi deletado do sistema com sucesso!", "Excluído com sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
                this.Dispose();
            }
        }

        private void editar()
        {
            limparErros();
            if (validar())
            {
                preencherFuncionario();
                if (servico.Update(funcionario))
                {
                    MetroFramework.MetroMessageBox.Show(this, "O funcionário " + funcionario.Nome + " " + funcionario.SobreNome + " foi alterado com sucesso!", "Alterado com sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
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
            preencherCombos(cmbEstadoCivil);
            preencherCombos(cmbDepartamento);
            preencherCombos(cmbEmpresa);
            
            preencherTela();

            tcCadastroFuncionario.StyleManager = this.StyleManager;
            tcCadastroFuncionario.Theme = this.StyleManager.Theme;
            tcCadastroFuncionario.SelectedIndex = 0; 

        }

        private void preencherCombos(MetroComboBox parNomeCombo)
        {
            switch(parNomeCombo.Name)
            {
                case "cmbEstado":
                    cmbEstado.DataSource = Enum.GetNames(typeof(Estados));
                    cmbEstado.DataSource = Enum.GetNames(typeof(Estados));
                    cmbEstado.AutoCompleteSource = AutoCompleteSource.ListItems;
                    cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmbEstado.DropDownHeight = 200;
                    cmbEstado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    foreach (var item in Enum.GetNames(typeof(Estados)))
                    {
                        cmbEstado.AutoCompleteCustomSource.Add(item);
                    }
                    break;
                case "cmbEstadoCivil":
                    cmbEstadoCivil.DataSource = Enum.GetNames(typeof(EstadoCivil));
                    break;
                case "cmbDepartamento":
                    DepartamentoService depService = new DepartamentoService(context);
                    cmbDepartamento.DataSource = depService.GetDepartamento();
                    cmbDepartamento.ValueMember = "Id";
                    cmbDepartamento.DisplayMember = "NomeDepartamento";
                    break;
                case "cmbEmpresa":
                    EmpresaService empresaService = new EmpresaService(context);
                    cmbEmpresa.DataSource = empresaService.GetEmpresa();
                    cmbEmpresa.ValueMember = "Id";
                    cmbEmpresa.DisplayMember = "NomeFantasia";
                    break;
            }
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

        private void btnLocalizarImg_Click(object sender, EventArgs e)
        {
            if (buscarArquivo.ShowDialog() == DialogResult.OK)
            {
                caminhoImagem = buscarArquivo.FileName;
                imgFoto.SizeMode = PictureBoxSizeMode.Zoom;

                imgFoto.ImageLocation = caminhoImagem;
                imagemByte = ConverterImagemParaBytes(caminhoImagem);
            }
        }

        public byte[] ConverterImagemParaBytes(string caminhoImagem)
        {
            byte[] arraybytes = null;

            FileInfo informacoesFicnheiro = new FileInfo(caminhoImagem);
            long numeroBytes = informacoesFicnheiro.Length;

            FileStream fStream = new FileStream(caminhoImagem, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fStream);

            arraybytes = br.ReadBytes((int)numeroBytes);

            return arraybytes;
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

        private void btCapturar_Click(object sender, EventArgs e)
        {
            frmWebCam janela = new frmWebCam();
            janela.ShowDialog();
            imgFoto.ImageLocation = janela.caminhoImagemSalva;
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            FuncaoService funcaoServico = new FuncaoService(context);
            if (cmbDepartamento.SelectedItem != null)
            {
                var funcoes = funcaoServico.GetFuncoes(((Departamento)cmbDepartamento.SelectedItem).Id);
                cmbFuncao.DataSource = funcoes;
                cmbFuncao.ValueMember = "Id";
                cmbFuncao.DisplayMember = "NomeFuncao";
            }
        }

        private void txtFolha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            bool CPFexiste = false;

            if (txtCPF.Text.Length == 11)
            {
                long CPF = Convert.ToInt64(txtCPF.Text);
                string CPFFormatado = String.Format(@"{0:000\.000\.000\-00}", CPF);
                txtCPF.Text = CPFFormatado;
            }

            if (operacao == Operacao.Inserir)
            {
                if (!String.IsNullOrEmpty(txtCPF.Text))
                {
                    if(servico.GetFuncionarioCPF(txtCPF.Text)!=null)
                        CPFexiste = true;
                }
                if (CPFexiste)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Esse CPF já está associado a um funcionário no sistema.", "Atenção!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                    limparTela();
                }
            }
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCEP.Text))
            {
                Endereco endereco = new Endereco();
                CEPCorreios cepCorreios = new CEPCorreios();
                endereco = cepCorreios.BuscaCep(txtCEP.Text);

                txtBairro.Text = endereco.Bairro;
                txtCidade.Text = endereco.Cidade;
                txtEndereco.Text = endereco.Logradouro;
                txtComplemento.Text = endereco.Complemento;
                cmbEstado.SelectedItem = endereco.Estado;
            }
        }
    }
}

using LabxPonto_Commons;
using LabxPonto_Commons.WebService;
using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
using LabxPonto_View.Enums;
using LabxPonto_View.Views.Base;
using LabxPonto_View.Views.Cam;
using MetroFramework.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
        byte[] imagemByte;

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

            if (String.IsNullOrEmpty(txtComplementoo.Text))
                errorProviderEmp.SetError(txtComplementoo, "Informe um Complemento do endereço da empresa.");

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
                (errorProviderEmp.GetError(txtComplementoo) == ""));
        }

        public void limparTela()
        {
            txtBairro.Text = "";
            txtCEP.Text = "";
            txtCidade.Text = "";
            txtComplementoo.Text = "";
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
            errorProviderEmp.SetError(txtComplementoo, "");
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

            if (empresa.Endereco != null)
            {
                txtEndereco.Text = empresa.Endereco.Logradouro;
                txtBairro.Text = empresa.Endereco.Bairro;
                txtCidade.Text = empresa.Endereco.Cidade;
                cmbEstado.Text = empresa.Endereco.Bairro;
                txtComplementoo.Text = empresa.Endereco.Complemento;
                txtCEP.Text = empresa.Endereco.Cep.ToString();
            }

            if ((operacao == Operacao.Visualizar)||
                (operacao == Operacao.Excluir))
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
                txtComplementoo.ReadOnly = true;
                txtCEP.ReadOnly = true;
                cmbEstado.Enabled = false;
                cbPais.Enabled = false;
                btCapturar.Enabled = false;
                btnLocalizarImg.Enabled = false;
            }

            if(operacao == Operacao.Visualizar)
            {
                btnSalvar.Visible = false;
                btnCancelar.Text = "Fechar";
            }

            if (empresa.Imagem != null)
                if (empresa.Imagem.Arquivo != null)
                {
                    preencherImagemByte(empresa.Imagem.Arquivo);
                    imagemByte = empresa.Imagem.Arquivo;
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
            empresa.Endereco.Complemento = txtComplementoo.Text;
            empresa.Endereco.Pais = cbPais.Text;

            if (!String.IsNullOrEmpty(txtCEP.Text))
                empresa.Endereco.Cep = Convert.ToInt32(txtCEP.Text);

            #region Imagem

            if (operacao == Operacao.Editar)
            {
                if (empresa.Imagem == null)
                    empresa.Imagem = new Imagem();

                if (imagemByte != null)
                    empresa.Imagem.Arquivo = imagemByte;
                else
                    empresa.Imagem.Arquivo = null;
            }
            else
            {
                if (imagemByte != null)
                {
                    empresa.Imagem = new Imagem();
                    empresa.Imagem.Arquivo = imagemByte;
                }
                else
                    empresa.Imagem = null;
            }
            #endregion
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
            if (servico.Delete(empresa))
            {
                MetroFramework.MetroMessageBox.Show(this, "A empresa " + empresa.NomeFantasia + " foi deletada com sucesso!", "Excluído com sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
                this.Dispose();
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

        private void preencherCombos(MetroComboBox parNomeCombo)
        {
            switch (parNomeCombo.Name)
            {
                case "cmbEstado":
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
                case "cbPais":
                    cbPais.DataSource = Enum.GetNames(typeof(Pais));
                    cbPais.AutoCompleteSource = AutoCompleteSource.ListItems;
                    cbPais.DropDownStyle = ComboBoxStyle.DropDownList;
                    cbPais.DropDownHeight = 200;
                    cbPais.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    foreach (var item in Enum.GetNames(typeof(Pais)))
                    {
                        cbPais.AutoCompleteCustomSource.Add(item);
                    }
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

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            string cnpjTexto = txtCNPJ.Text.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpjTexto.Length == 14)
            {
                long CNPJ = Convert.ToInt64(cnpjTexto);
                string CNPJFormatado = String.Format(@"{0:00\.000\.000\/0000\-00}", CNPJ);
                txtCNPJ.Text = CNPJFormatado;
            }
        }

        private void frmEmpresaCadastro_Load(object sender, EventArgs e)
        {
            preencherCombos(cmbEstado);
            preencherCombos(cbPais);

            if (operacao == Operacao.Inserir)
                empresa.Endereco = new Endereco();

            tcCadastroFuncionario.StyleManager = this.StyleManager;

        }

        private void btnCancelar_Click_2(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCEP.Text))
            {
                endereco = new Endereco();
                CEPCorreios cepCorreios = new CEPCorreios();
                endereco = cepCorreios.BuscaCep(txtCEP.Text);

                txtBairro.Text = endereco.Bairro;
                txtCidade.Text = endereco.Cidade;
                txtEndereco.Text = endereco.Logradouro;
                txtComplementoo.Text = endereco.Complemento;
                cmbEstado.SelectedItem = endereco.Estado;
            }
        }

        private void btnLocalizarImg_Click(object sender, EventArgs e)
        {
            if (buscarArquivo.ShowDialog() == DialogResult.OK)
            {
                caminhoImagem = buscarArquivo.FileName;

                Image imagem = resizeImage(300, 300, caminhoImagem);

                imgFoto.SizeMode = PictureBoxSizeMode.Zoom;
                string caminhoImagemSalva = Path.GetTempFileName() + "ImagemWebCam" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Millisecond.ToString() + ".jpg";
                imagem.Save(caminhoImagemSalva);
                imgFoto.Image = imagem;
                imagemByte = ConverterImagemParaBytes(caminhoImagemSalva);

                //imgFoto.ImageLocation = caminhoImagem;
                //imagemByte = ConverterImagemParaBytes(caminhoImagem);
            }
        }

        public Image resizeImage(int newWidth, int newHeight, string stPhotoPath)
        {
            Image imgPhoto = Image.FromFile(stPhotoPath);

            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;

            //Consider vertical pics
            if (sourceWidth < sourceHeight)
            {
                int buff = newWidth;

                newWidth = newHeight;
                newHeight = buff;
            }

            int sourceX = 0, sourceY = 0, destX = 0, destY = 0;
            float nPercent = 0, nPercentW = 0, nPercentH = 0;

            nPercentW = ((float)newWidth / (float)sourceWidth);
            nPercentH = ((float)newHeight / (float)sourceHeight);
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((newWidth -
                          (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((newHeight -
                          (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);


            Bitmap bmPhoto = new Bitmap(newWidth, newHeight,
                          PixelFormat.Format24bppRgb);

            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                         imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.Black);
            grPhoto.InterpolationMode =
                System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            imgPhoto.Dispose();
            return bmPhoto;
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

        private void btCapturar_Click(object sender, EventArgs e)
        {
            frmWebCam janela = new frmWebCam();
            janela.ShowDialog();
            imgFoto.ImageLocation = janela.caminhoImagemSalva;
        }
    }
}

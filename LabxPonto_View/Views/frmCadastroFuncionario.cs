using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
using LabxPonto_View.Views;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LabxPonto_View.Forms
{
    public partial class frmCadastroFuncionario : MetroForm
    {

        public frmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            PreencherObjeto();

        }

        public void PreencherObjeto()
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Nome = txtNomeFuncionario.Text;
            funcionario.SobreNome = txtSobreNome.Text;
            funcionario.CPF = txtCPF.Text;
            funcionario.DataNascimento = dtDataNascimento.Value;
            funcionario.RG = txtRG.Text;
            funcionario.NomePai = txtNomePai.Text;
            funcionario.NomeMae = txtNomeMae.Text;

            Confirmar(funcionario);
        }

        public void Confirmar(Funcionario funcionario)
        {

        }
        public void Validar()
        {
            if (String.IsNullOrEmpty(txtFolha.Text))
                txtFolha.WithError = true;
        }

        private void btnLocalizarImg_Click(object sender, System.EventArgs e)
        {
            //OpenFileDialog
            this.ofd1.Title = "Selecionar Fotos";
            //filtra para exibir somente arquivos de imagens
            ofd1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;
            DialogResult dr = this.ofd1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
               PictureBox pb = new PictureBox();
               Image Imagem = Image.FromFile(ofd1.FileName);
               pb.SizeMode = PictureBoxSizeMode.StretchImage;
               pb.Height = 100;
               pb.Width = 100;
               pb.Image = Imagem;

               imgFoto.Image = pb.Image;
            }
        }

        private void btnPesquisar_Click(object sender, System.EventArgs e)
        {
          
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            frmEditarFuncionario editarFuncionario = new frmEditarFuncionario();
            editarFuncionario.ShowDialog();
        }

        private void frmCadastroFuncionario_Load(object sender, System.EventArgs e)
        {
            preencherComboDepartamento();
        }

        public void preencherComboFuncao(string departamento)
        {
            Funcao funcao = new Funcao();
            FuncaoService funcaoService = new FuncaoService();
            Departamento dep = new Departamento();

            var lista = funcaoService.GetFuncao(departamento);

            foreach (var item in lista)
                cbFuncaoFunc.Items.Add(item.NomeFuncao);
        }

        public void preencherComboDepartamento()
        {
            Funcao funcao = new Funcao();
            FuncaoService funcaoService = new FuncaoService();
            DepartamentoService departamentoService = new DepartamentoService();
            Departamento dep = new Departamento();

            var lista  = departamentoService.GetDepartamento();

            foreach (var item in lista)
            {
                cbDepartamentoFunc.Items.Add(item.NomeDepartamento);
                //cbDepartamento.Items.Add(item.NomeDepartamento);
            }
        }

        private void cbDepartamentoFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string departamento = "";
            departamento = cbDepartamentoFunc.SelectedItem.ToString();
            preencherComboFuncao(departamento);
        }

        public void preencherObjetoDepartamento()
        {
            Departamento departamento = new Departamento();

            //departamento.NomeDepartamento = txtNomeDepartamento.Text;
            //departamento.Descricao = txtDescricaoDepartamento.Text;

            ConfirmarDepartamento(departamento);
        }
        public void ConfirmarDepartamento(Departamento departamento)
        {
            DepartamentoService departamentoService = new DepartamentoService();
            departamentoService.Insert(departamento);
        }

        private void btnSalvarDepartamento_Click(object sender, EventArgs e)
        {
            preencherObjetoDepartamento();
        }
    }
}

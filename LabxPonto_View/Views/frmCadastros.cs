using LabxPonto_View.Model;
using MetroFramework.Forms;
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
            Service
        }
        public void Validar()
        {

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
    }
}

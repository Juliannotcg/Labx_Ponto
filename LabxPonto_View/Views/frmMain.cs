using LabxPonto_Dao.Data.Context;
using LabxPonto_View.Views.Configurações;
using LabxPonto_View.Views.Departamentos;
using LabxPonto_View.Views.Empresas;
using LabxPonto_View.Views.Funcionarios;
using LabxPonto_View.Views.Funções;
//using LabxPonto_View.Views.Usuário;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Win32;
using System.IO;
using System.Windows.Forms;

namespace LabxPonto_View.Views
{
    public partial class frmMain : MetroForm
    {
        AppDataContext context = new AppDataContext();
        public frmMain()
        {
            InitializeComponent();
            StyleManager = metroStyleManager;
            verificarArquivoConfiguracao();
        }

        public void mtCadastro_Click(object sender, System.EventArgs e)
        {
            frmFuncionarios janela = new frmFuncionarios(context);
            janela.StyleManager = metroStyleManager;
            janela.ShowDialog();
        }

        private void btnDepartamento_Click(object sender, System.EventArgs e)
        {
            frmDepartamentos janela = new frmDepartamentos(context);
            janela.StyleManager = metroStyleManager;
            janela.ShowDialog();
        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void mtConfiguracoes_Click(object sender, System.EventArgs e)
        {
            frmConfiguracoes janela = new frmConfiguracoes();
            janela.StyleManager = metroStyleManager;
            janela.Show();
        }

        private void btnFuncoes_Click(object sender, System.EventArgs e)
        {
            frmFuncoes janela = new frmFuncoes(context);
            janela.StyleManager = metroStyleManager;
            janela.ShowDialog();
        }

        private void btnEmpresa_Click(object sender, System.EventArgs e)
        {
            frmEmpresas janela = new frmEmpresas(context);
            janela.StyleManager = metroStyleManager;
            janela.ShowDialog();
        }

        private void metroTile2_Click(object sender, System.EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Funcionalidade em desenvolvimento", "Atenção!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
        }

        private void metroTile3_Click(object sender, System.EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Funcionalidade em desenvolvimento", "Atenção!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
        }

        private void metroTile1_Click(object sender, System.EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Funcionalidade em desenvolvimento", "Atenção!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
        }

        private void btTema_Click(object sender, System.EventArgs e)
        {
            metroStyleManager.Theme = metroStyleManager.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
            salvarConfiguracaoTema();
        }

        public void verificarArquivoConfiguracao()
        {
            string caminhoArquivo = Path.GetTempPath();
            caminhoArquivo += @"ePonto";

            if (!Directory.Exists(caminhoArquivo))
            {
                Directory.CreateDirectory(caminhoArquivo);
                caminhoArquivo += @"\config.txt";
                File.WriteAllText(caminhoArquivo, metroStyleManager.Theme.ToString());
            }
            else
            {
                StreamReader file = new StreamReader(caminhoArquivo + @"\config.txt");
                var linha = file.ReadLine();
                   if(linha == "Dark")
                    metroStyleManager.Theme = MetroThemeStyle.Dark;
                   else
                    metroStyleManager.Theme = MetroThemeStyle.Light;
                file.Close();
            }
        }

        public void salvarConfiguracaoTema()
        {
            string caminhoArquivo = Path.GetTempPath();
            caminhoArquivo += @"ePonto";

            if (!Directory.Exists(caminhoArquivo))
                Directory.CreateDirectory(caminhoArquivo);
                
            caminhoArquivo += @"\config.txt";
            File.WriteAllText(caminhoArquivo, metroStyleManager.Theme.ToString());
        }

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnUsuario_Click(object sender, System.EventArgs e)
        {
            //frmUsuario janela = new frmUsuario();
            //janela.Show();
        }
    }
}

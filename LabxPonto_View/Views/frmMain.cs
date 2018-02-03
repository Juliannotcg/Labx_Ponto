using LabxPonto_Commons;
using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
using LabxPonto_View.Views.Biometria;
using LabxPonto_View.Views.Configurações;
using LabxPonto_View.Views.Departamentos;
using LabxPonto_View.Views.Empresas;
using LabxPonto_View.Views.Funcionarios;
using LabxPonto_View.Views.Funções;
using LabxPonto_View.Views.Horários;
using LabxPonto_View.Views.Suporte;
using LabxPonto_View.Views.Usuário;
//using LabxPonto_View.Views.Usuário;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Win32;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LabxPonto_View.Views
{
    public partial class frmMain : MetroForm
    {
        AppDataContext context;
        Usuario usuario;
        UsuarioServico servico;
        public Usuario Usuario
        {
            get { return (usuario); }
            set { usuario = value; }
        }

        public frmMain(AppDataContext contexto)
        {
            InitializeComponent();
            context = contexto;
            StyleManager = metroStyleManager;
            verificarArquivoConfiguracao();
        }

        private void NotificarUsuarioLogado()
        {
            iconeNotificacao.Icon = SystemIcons.Information;
            iconeNotificacao.BalloonTipIcon = ToolTipIcon.Info;
            iconeNotificacao.BalloonTipText = "Usuário " + usuario.Login.ToString() + " logado no sistema";
            iconeNotificacao.BalloonTipTitle = "Aviso";
            iconeNotificacao.Visible = true;
            iconeNotificacao.ShowBalloonTip(5000);
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
            frmGerarArquivo janela = new frmGerarArquivo(context);
            janela.StyleManager = metroStyleManager;
            janela.Show();
        }

        private void metroTile3_Click(object sender, System.EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Funcionalidade em desenvolvimento", "Atenção!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
        }

        private void metroTile1_Click(object sender, System.EventArgs e)
        {
            frmRelatorios janela = new frmRelatorios(context);
            janela.Show();
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
            servico = new UsuarioServico(context);
            Criptografar cript = new Criptografar();
            string senhaCript = "";

            senhaCript = cript.Base64Encode(usuario.Senha);

            if (usuario != null)
            {
                usuario = servico.GetUsuario(usuario.Login, senhaCript);

                if (usuario.Perfil.ToString() == "Funcionário")
                    TelaFuncionario();

                if (usuario.Perfil.ToString() == "Usuário padrão")
                    TelaAdministrativo();

                lbUsuario.Text = "Usuário " + usuario.Login.ToString() + " logado.";
                NotificarUsuarioLogado();
            }
            
            lblVersao.Text = "Versão: " + Application.ProductVersion;

            this.WindowState = FormWindowState.Maximized;
        }

        public void TelaFuncionario()
        {
            btnFuncionario.Visible = false;
            btnBiometria.Visible = false;
            btnFuncoes.Visible = false;
            btnDepartamento.Visible = false;
            btnEmpresa.Visible = false;
            btnFuncoes.Visible = false;
            btnLerArquivo.Visible = false;
            btnGerarArquivo.Visible = false;
            btnHorario.Visible = false;
            btnUsuario.Visible = false;
            btnRelatorios.Visible = false;
            mtConfiguracoes.Visible = false;
            lbArquivo.Visible = false;
            lbCadastro.Visible = false;
            lbHorario.Visible = false;
            lblUsuario.Visible = false;
            lbSistema.Visible = false;

            bPonto.Location = new Point(37, 337);
            btnSair.Location = new Point(287, 337);

            frmBaterPonto janela = new frmBaterPonto(context);
            janela.ShowDialog();
        }

        public void TelaAdministrativo()
        {
            mtConfiguracoes.Visible = false;
            lbSistema.Visible = false;
        }
        private void btnUsuario_Click(object sender, System.EventArgs e)
        {
            frmUsuario janela = new frmUsuario(context);
            janela.StyleManager = metroStyleManager;
            janela.Show();
        }

        private void btnBiometria_Click(object sender, System.EventArgs e)
        {
            frmBiometria janela = new frmBiometria(context);
            janela.Show();
        }

        private void btnSuporte_Click(object sender, System.EventArgs e)
        {
            frmSuporte janela = new frmSuporte();
            janela.Show();
        }

        private void btnHorario_Click(object sender, System.EventArgs e)
        {
            frmHorarios janela = new frmHorarios(this.context);
            janela.Show();
        }

        private void bPonto_Click(object sender, System.EventArgs e)
        {
            frmBaterPonto janela = new frmBaterPonto(context);
            janela.Show();
        }

        private void btnLerArquivo_Click(object sender, System.EventArgs e)
        {
            frmLerArquivo janela = new frmLerArquivo(context);
            janela.Show();
        }
    }
}

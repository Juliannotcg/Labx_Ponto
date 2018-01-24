namespace LabxPonto_View.Views
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.btnDepartamento = new MetroFramework.Controls.MetroTile();
            this.btnEmpresa = new MetroFramework.Controls.MetroTile();
            this.btnFuncoes = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.btnUsuario = new MetroFramework.Controls.MetroTile();
            this.btnSuporte = new MetroFramework.Controls.MetroTile();
            this.btnHorario = new MetroFramework.Controls.MetroTile();
            this.bPonto = new MetroFramework.Controls.MetroTile();
            this.btnLerArquivo = new MetroFramework.Controls.MetroTile();
            this.btnBiometria = new MetroFramework.Controls.MetroTile();
            this.btTema = new MetroFramework.Controls.MetroTile();
            this.btnSair = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mtConfiguracoes = new MetroFramework.Controls.MetroTile();
            this.btnFuncionario = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbVersao = new System.Windows.Forms.Label();
            this.iconeNotificacao = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblVersao = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.metroTile2.Location = new System.Drawing.Point(455, 274);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(175, 151);
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Text = "Gerar Arquivo";
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroToolTip1.SetToolTip(this.metroTile2, "Gerar arquivo");
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // btnDepartamento
            // 
            this.btnDepartamento.ActiveControl = null;
            this.btnDepartamento.Location = new System.Drawing.Point(24, 431);
            this.btnDepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDepartamento.Name = "btnDepartamento";
            this.btnDepartamento.Size = new System.Drawing.Size(185, 97);
            this.btnDepartamento.TabIndex = 6;
            this.btnDepartamento.Text = "Departamentos";
            this.btnDepartamento.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroToolTip1.SetToolTip(this.btnDepartamento, "Cadastro de departamentos");
            this.btnDepartamento.UseSelectable = true;
            this.btnDepartamento.Click += new System.EventHandler(this.btnDepartamento_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.ActiveControl = null;
            this.btnEmpresa.Location = new System.Drawing.Point(215, 274);
            this.btnEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(185, 151);
            this.btnEmpresa.TabIndex = 7;
            this.btnEmpresa.Text = "Empresas";
            this.btnEmpresa.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroToolTip1.SetToolTip(this.btnEmpresa, "Cadastro de empresas");
            this.btnEmpresa.UseSelectable = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // btnFuncoes
            // 
            this.btnFuncoes.ActiveControl = null;
            this.btnFuncoes.Location = new System.Drawing.Point(215, 431);
            this.btnFuncoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFuncoes.Name = "btnFuncoes";
            this.btnFuncoes.Size = new System.Drawing.Size(185, 97);
            this.btnFuncoes.TabIndex = 8;
            this.btnFuncoes.Text = "Funções";
            this.btnFuncoes.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroToolTip1.SetToolTip(this.btnFuncoes, "Cadastro de funções");
            this.btnFuncoes.UseSelectable = true;
            this.btnFuncoes.Click += new System.EventHandler(this.btnFuncoes_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(24, 254);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 15);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Cadastros";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(455, 254);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(117, 15);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Arquivos / Relatórios";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(24, 546);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 15);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Sistema";
            // 
            // pbLogo
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.pbLogo, true);
            this.pbLogo.Image = global::LabxPonto_View.Properties.Resources.LogoEmpresa;
            this.pbLogo.Location = new System.Drawing.Point(284, 32);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(488, 143);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnUsuario
            // 
            this.btnUsuario.ActiveControl = null;
            this.btnUsuario.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUsuario.Location = new System.Drawing.Point(862, 494);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(175, 151);
            this.btnUsuario.TabIndex = 15;
            this.btnUsuario.Text = "Usuário";
            this.btnUsuario.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroToolTip1.SetToolTip(this.btnUsuario, "Gerar arquivo");
            this.btnUsuario.UseCustomBackColor = true;
            this.btnUsuario.UseSelectable = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnSuporte
            // 
            this.btnSuporte.ActiveControl = null;
            this.btnSuporte.BackColor = System.Drawing.Color.Teal;
            this.btnSuporte.Location = new System.Drawing.Point(4, 11);
            this.btnSuporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuporte.Name = "btnSuporte";
            this.btnSuporte.Size = new System.Drawing.Size(153, 42);
            this.btnSuporte.TabIndex = 25;
            this.btnSuporte.Text = "Suporte";
            this.btnSuporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuporte.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroToolTip1.SetToolTip(this.btnSuporte, "Gerar arquivo");
            this.btnSuporte.UseCustomBackColor = true;
            this.btnSuporte.UseSelectable = true;
            this.btnSuporte.Click += new System.EventHandler(this.btnSuporte_Click);
            // 
            // btnHorario
            // 
            this.btnHorario.ActiveControl = null;
            this.btnHorario.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHorario.Location = new System.Drawing.Point(455, 561);
            this.btnHorario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHorario.Name = "btnHorario";
            this.btnHorario.Size = new System.Drawing.Size(174, 91);
            this.btnHorario.TabIndex = 19;
            this.btnHorario.Text = "Horários";
            this.btnHorario.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroToolTip1.SetToolTip(this.btnHorario, "Horários");
            this.btnHorario.UseCustomBackColor = true;
            this.btnHorario.UseSelectable = true;
            this.btnHorario.UseTileImage = true;
            this.btnHorario.Click += new System.EventHandler(this.btnHorario_Click);
            // 
            // bPonto
            // 
            this.bPonto.ActiveControl = null;
            this.bPonto.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bPonto.Location = new System.Drawing.Point(455, 656);
            this.bPonto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bPonto.Name = "bPonto";
            this.bPonto.Size = new System.Drawing.Size(175, 58);
            this.bPonto.TabIndex = 26;
            this.bPonto.Text = "Ponto";
            this.bPonto.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroToolTip1.SetToolTip(this.bPonto, "Gerar arquivo");
            this.bPonto.UseCustomBackColor = true;
            this.bPonto.UseSelectable = true;
            this.bPonto.UseTileImage = true;
            this.bPonto.Click += new System.EventHandler(this.bPonto_Click);
            // 
            // btnLerArquivo
            // 
            this.btnLerArquivo.ActiveControl = null;
            this.btnLerArquivo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLerArquivo.Location = new System.Drawing.Point(455, 431);
            this.btnLerArquivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLerArquivo.Name = "btnLerArquivo";
            this.btnLerArquivo.Size = new System.Drawing.Size(175, 97);
            this.btnLerArquivo.TabIndex = 26;
            this.btnLerArquivo.Text = "Ler Arquivo";
            this.btnLerArquivo.TileImage = global::LabxPonto_View.Properties.Resources.folders;
            this.btnLerArquivo.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnLerArquivo.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroToolTip1.SetToolTip(this.btnLerArquivo, "Ler arquivo");
            this.btnLerArquivo.UseCustomBackColor = true;
            this.btnLerArquivo.UseSelectable = true;
            this.btnLerArquivo.UseTileImage = true;
            this.btnLerArquivo.Click += new System.EventHandler(this.btnLerArquivo_Click);
            // 
            // btnBiometria
            // 
            this.btnBiometria.ActiveControl = null;
            this.btnBiometria.Location = new System.Drawing.Point(635, 561);
            this.btnBiometria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBiometria.Name = "btnBiometria";
            this.btnBiometria.Size = new System.Drawing.Size(175, 151);
            this.btnBiometria.TabIndex = 20;
            this.btnBiometria.Text = "Biometria";
            this.btnBiometria.TileImage = global::LabxPonto_View.Properties.Resources.icons8_leitor_de_impressão_digital_100;
            this.btnBiometria.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBiometria.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroToolTip1.SetToolTip(this.btnBiometria, "Ler arquivo");
            this.btnBiometria.UseSelectable = true;
            this.btnBiometria.UseTileImage = true;
            this.btnBiometria.Click += new System.EventHandler(this.btnBiometria_Click);
            // 
            // btTema
            // 
            this.btTema.ActiveControl = null;
            this.btTema.BackColor = System.Drawing.Color.Transparent;
            this.btTema.Location = new System.Drawing.Point(987, 433);
            this.btTema.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTema.Name = "btTema";
            this.btTema.PaintTileCount = false;
            this.btTema.Size = new System.Drawing.Size(50, 53);
            this.btTema.TabIndex = 13;
            this.btTema.TileImage = global::LabxPonto_View.Properties.Resources.theme1;
            this.metroToolTip1.SetToolTip(this.btTema, "Alterar tema");
            this.btTema.UseCustomBackColor = true;
            this.btTema.UseMnemonic = false;
            this.btTema.UseSelectable = true;
            this.btTema.UseTileImage = true;
            this.btTema.Click += new System.EventHandler(this.btTema_Click);
            // 
            // btnSair
            // 
            this.btnSair.ActiveControl = null;
            this.btnSair.BackColor = System.Drawing.Color.SlateGray;
            this.btnSair.Location = new System.Drawing.Point(862, 649);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(175, 65);
            this.btnSair.Style = MetroFramework.MetroColorStyle.Red;
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.TileImage = global::LabxPonto_View.Properties.Resources.power;
            this.btnSair.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSair.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroToolTip1.SetToolTip(this.btnSair, "Sair do sistema");
            this.btnSair.UseSelectable = true;
            this.btnSair.UseStyleColors = true;
            this.btnSair.UseTileImage = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.metroTile1.Location = new System.Drawing.Point(635, 431);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(175, 97);
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "Relatórios";
            this.metroTile1.TileImage = global::LabxPonto_View.Properties.Resources.newspaper;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroToolTip1.SetToolTip(this.metroTile1, "Gerar relatórios");
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // mtConfiguracoes
            // 
            this.mtConfiguracoes.ActiveControl = null;
            this.mtConfiguracoes.Location = new System.Drawing.Point(23, 567);
            this.mtConfiguracoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtConfiguracoes.Name = "mtConfiguracoes";
            this.mtConfiguracoes.Size = new System.Drawing.Size(377, 145);
            this.mtConfiguracoes.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtConfiguracoes.TabIndex = 2;
            this.mtConfiguracoes.Text = "Configurações";
            this.mtConfiguracoes.TileImage = global::LabxPonto_View.Properties.Resources.config;
            this.mtConfiguracoes.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroToolTip1.SetToolTip(this.mtConfiguracoes, "Acessar as configurações do sistema");
            this.mtConfiguracoes.UseSelectable = true;
            this.mtConfiguracoes.UseTileImage = true;
            this.mtConfiguracoes.Click += new System.EventHandler(this.mtConfiguracoes_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.ActiveControl = null;
            this.btnFuncionario.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFuncionario.Location = new System.Drawing.Point(24, 274);
            this.btnFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(185, 151);
            this.btnFuncionario.TabIndex = 1;
            this.btnFuncionario.Text = "Funcionários";
            this.btnFuncionario.TileImage = global::LabxPonto_View.Properties.Resources.user_list;
            this.btnFuncionario.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFuncionario.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroToolTip1.SetToolTip(this.btnFuncionario, "Cadastro de funcionários");
            this.btnFuncionario.UseCustomBackColor = true;
            this.btnFuncionario.UseSelectable = true;
            this.btnFuncionario.Click += new System.EventHandler(this.mtCadastro_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(862, 477);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(47, 15);
            this.metroLabel4.TabIndex = 17;
            this.metroLabel4.Text = "Usuário";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(455, 544);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(108, 15);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Horários/Biometria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(403, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "SISTEMA E-PONTO";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbUsuario.Location = new System.Drawing.Point(27, 222);
            this.lbUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(0, 24);
            this.lbUsuario.TabIndex = 23;
            // 
            // lbVersao
            // 
            this.lbVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbVersao.AutoSize = true;
            this.lbVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbVersao.Location = new System.Drawing.Point(25, 967);
            this.lbVersao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVersao.Name = "lbVersao";
            this.lbVersao.Size = new System.Drawing.Size(0, 16);
            this.lbVersao.TabIndex = 24;
            // 
            // iconeNotificacao
            // 
            this.iconeNotificacao.Text = "E-Ponto";
            this.iconeNotificacao.Visible = true;
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(4, 729);
            this.lblVersao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(51, 19);
            this.lblVersao.TabIndex = 27;
            this.lblVersao.Text = "Versão:";
            // 
            // frmMain
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 748);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnLerArquivo);
            this.Controls.Add(this.bPonto);
            this.Controls.Add(this.btnSuporte);
            this.Controls.Add(this.lbVersao);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btnBiometria);
            this.Controls.Add(this.btnHorario);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btTema);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFuncoes);
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.btnDepartamento);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mtConfiguracoes);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.pbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private MetroFramework.Controls.MetroTile mtConfiguracoes;
        private MetroFramework.Controls.MetroTile metroTile1;
        public MetroFramework.Controls.MetroTile btnFuncionario;
        public MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile btnDepartamento;
        public MetroFramework.Controls.MetroTile btnEmpresa;
        public MetroFramework.Controls.MetroTile btnFuncoes;
        public MetroFramework.Controls.MetroTile btnSair;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        public MetroFramework.Controls.MetroTile btTema;
        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        public MetroFramework.Controls.MetroTile btnBiometria;
        public MetroFramework.Controls.MetroTile btnHorario;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        public MetroFramework.Controls.MetroTile btnUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbVersao;
        public MetroFramework.Controls.MetroTile btnSuporte;
        private System.Windows.Forms.NotifyIcon iconeNotificacao;
        public MetroFramework.Controls.MetroTile btnLerArquivo;
        public MetroFramework.Controls.MetroTile bPonto;
        private MetroFramework.Controls.MetroLabel lblVersao;
    }
}
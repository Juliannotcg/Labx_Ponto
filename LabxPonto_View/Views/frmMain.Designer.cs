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
            this.btnGerarArquivo = new MetroFramework.Controls.MetroTile();
            this.btnDepartamento = new MetroFramework.Controls.MetroTile();
            this.btnEmpresa = new MetroFramework.Controls.MetroTile();
            this.btnFuncoes = new MetroFramework.Controls.MetroTile();
            this.lbCadastro = new MetroFramework.Controls.MetroLabel();
            this.lbArquivo = new MetroFramework.Controls.MetroLabel();
            this.lbSistema = new MetroFramework.Controls.MetroLabel();
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
            this.btnRelatorios = new MetroFramework.Controls.MetroTile();
            this.mtConfiguracoes = new MetroFramework.Controls.MetroTile();
            this.btnFuncionario = new MetroFramework.Controls.MetroTile();
            this.lblUsuario = new MetroFramework.Controls.MetroLabel();
            this.lbHorario = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbVersao = new System.Windows.Forms.Label();
            this.iconeNotificacao = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblVersao = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerarArquivo
            // 
            this.btnGerarArquivo.ActiveControl = null;
            this.btnGerarArquivo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGerarArquivo.Location = new System.Drawing.Point(607, 337);
            this.btnGerarArquivo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGerarArquivo.Name = "btnGerarArquivo";
            this.btnGerarArquivo.Size = new System.Drawing.Size(233, 186);
            this.btnGerarArquivo.TabIndex = 4;
            this.btnGerarArquivo.Text = "Gerar Arquivo";
            this.btnGerarArquivo.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroToolTip1.SetToolTip(this.btnGerarArquivo, "Gerar arquivo");
            this.btnGerarArquivo.UseCustomBackColor = true;
            this.btnGerarArquivo.UseSelectable = true;
            this.btnGerarArquivo.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // btnDepartamento
            // 
            this.btnDepartamento.ActiveControl = null;
            this.btnDepartamento.Location = new System.Drawing.Point(32, 530);
            this.btnDepartamento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnDepartamento.Name = "btnDepartamento";
            this.btnDepartamento.Size = new System.Drawing.Size(247, 119);
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
            this.btnEmpresa.Location = new System.Drawing.Point(287, 337);
            this.btnEmpresa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(247, 186);
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
            this.btnFuncoes.Location = new System.Drawing.Point(287, 530);
            this.btnFuncoes.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnFuncoes.Name = "btnFuncoes";
            this.btnFuncoes.Size = new System.Drawing.Size(247, 119);
            this.btnFuncoes.TabIndex = 8;
            this.btnFuncoes.Text = "Funções";
            this.btnFuncoes.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroToolTip1.SetToolTip(this.btnFuncoes, "Cadastro de funções");
            this.btnFuncoes.UseSelectable = true;
            this.btnFuncoes.Click += new System.EventHandler(this.btnFuncoes_Click);
            // 
            // lbCadastro
            // 
            this.lbCadastro.AutoSize = true;
            this.lbCadastro.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbCadastro.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbCadastro.Location = new System.Drawing.Point(32, 313);
            this.lbCadastro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbCadastro.Name = "lbCadastro";
            this.lbCadastro.Size = new System.Drawing.Size(67, 17);
            this.lbCadastro.TabIndex = 10;
            this.lbCadastro.Text = "Cadastros";
            // 
            // lbArquivo
            // 
            this.lbArquivo.AutoSize = true;
            this.lbArquivo.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbArquivo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbArquivo.Location = new System.Drawing.Point(607, 313);
            this.lbArquivo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbArquivo.Name = "lbArquivo";
            this.lbArquivo.Size = new System.Drawing.Size(131, 17);
            this.lbArquivo.TabIndex = 11;
            this.lbArquivo.Text = "Arquivos / Relatórios";
            // 
            // lbSistema
            // 
            this.lbSistema.AutoSize = true;
            this.lbSistema.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbSistema.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbSistema.Location = new System.Drawing.Point(32, 672);
            this.lbSistema.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbSistema.Name = "lbSistema";
            this.lbSistema.Size = new System.Drawing.Size(53, 17);
            this.lbSistema.TabIndex = 12;
            this.lbSistema.Text = "Sistema";
            // 
            // pbLogo
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.pbLogo, true);
            this.pbLogo.Location = new System.Drawing.Point(379, 39);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(651, 176);
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
            this.btnUsuario.Location = new System.Drawing.Point(1149, 608);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(233, 186);
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
            this.btnSuporte.Location = new System.Drawing.Point(5, 14);
            this.btnSuporte.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSuporte.Name = "btnSuporte";
            this.btnSuporte.Size = new System.Drawing.Size(204, 52);
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
            this.btnHorario.Location = new System.Drawing.Point(607, 690);
            this.btnHorario.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnHorario.Name = "btnHorario";
            this.btnHorario.Size = new System.Drawing.Size(232, 112);
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
            this.bPonto.Location = new System.Drawing.Point(607, 807);
            this.bPonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bPonto.Name = "bPonto";
            this.bPonto.Size = new System.Drawing.Size(233, 71);
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
            this.btnLerArquivo.Location = new System.Drawing.Point(607, 530);
            this.btnLerArquivo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLerArquivo.Name = "btnLerArquivo";
            this.btnLerArquivo.Size = new System.Drawing.Size(233, 119);
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
            this.btnBiometria.Location = new System.Drawing.Point(847, 690);
            this.btnBiometria.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBiometria.Name = "btnBiometria";
            this.btnBiometria.Size = new System.Drawing.Size(233, 186);
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
            this.btTema.Location = new System.Drawing.Point(1316, 533);
            this.btTema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTema.Name = "btTema";
            this.btTema.PaintTileCount = false;
            this.btTema.Size = new System.Drawing.Size(67, 65);
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
            this.btnSair.Location = new System.Drawing.Point(1149, 799);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(233, 80);
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
            // btnRelatorios
            // 
            this.btnRelatorios.ActiveControl = null;
            this.btnRelatorios.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRelatorios.Location = new System.Drawing.Point(847, 530);
            this.btnRelatorios.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(233, 119);
            this.btnRelatorios.TabIndex = 3;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.TileImage = global::LabxPonto_View.Properties.Resources.newspaper;
            this.btnRelatorios.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnRelatorios.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroToolTip1.SetToolTip(this.btnRelatorios, "Gerar relatórios");
            this.btnRelatorios.UseCustomBackColor = true;
            this.btnRelatorios.UseSelectable = true;
            this.btnRelatorios.UseTileImage = true;
            this.btnRelatorios.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // mtConfiguracoes
            // 
            this.mtConfiguracoes.ActiveControl = null;
            this.mtConfiguracoes.Location = new System.Drawing.Point(31, 698);
            this.mtConfiguracoes.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.mtConfiguracoes.Name = "mtConfiguracoes";
            this.mtConfiguracoes.Size = new System.Drawing.Size(503, 178);
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
            this.btnFuncionario.Location = new System.Drawing.Point(32, 337);
            this.btnFuncionario.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(247, 186);
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
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblUsuario.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblUsuario.Location = new System.Drawing.Point(1149, 587);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 17);
            this.lblUsuario.TabIndex = 17;
            this.lblUsuario.Text = "Usuário";
            // 
            // lbHorario
            // 
            this.lbHorario.AutoSize = true;
            this.lbHorario.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbHorario.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbHorario.Location = new System.Drawing.Point(607, 670);
            this.lbHorario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(119, 17);
            this.lbHorario.TabIndex = 21;
            this.lbHorario.Text = "Horários/Biometria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(537, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 38);
            this.label1.TabIndex = 22;
            this.label1.Text = "SISTEMA E-PONTO";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbUsuario.Location = new System.Drawing.Point(36, 273);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(0, 29);
            this.lbUsuario.TabIndex = 23;
            // 
            // lbVersao
            // 
            this.lbVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbVersao.AutoSize = true;
            this.lbVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbVersao.Location = new System.Drawing.Point(33, 1190);
            this.lbVersao.Name = "lbVersao";
            this.lbVersao.Size = new System.Drawing.Size(0, 20);
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
            this.lblVersao.Location = new System.Drawing.Point(5, 897);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(54, 20);
            this.lblVersao.TabIndex = 27;
            this.lblVersao.Text = "Versão:";
            // 
            // frmMain
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 921);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnLerArquivo);
            this.Controls.Add(this.bPonto);
            this.Controls.Add(this.btnSuporte);
            this.Controls.Add(this.lbVersao);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHorario);
            this.Controls.Add(this.btnBiometria);
            this.Controls.Add(this.btnHorario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btTema);
            this.Controls.Add(this.lbSistema);
            this.Controls.Add(this.lbArquivo);
            this.Controls.Add(this.lbCadastro);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFuncoes);
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.btnDepartamento);
            this.Controls.Add(this.btnGerarArquivo);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.mtConfiguracoes);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.pbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
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
        private MetroFramework.Controls.MetroTile btnRelatorios;
        public MetroFramework.Controls.MetroTile btnFuncionario;
        public MetroFramework.Controls.MetroTile btnGerarArquivo;
        private MetroFramework.Controls.MetroTile btnDepartamento;
        public MetroFramework.Controls.MetroTile btnEmpresa;
        public MetroFramework.Controls.MetroTile btnFuncoes;
        public MetroFramework.Controls.MetroTile btnSair;
        private MetroFramework.Controls.MetroLabel lbCadastro;
        private MetroFramework.Controls.MetroLabel lbArquivo;
        private MetroFramework.Controls.MetroLabel lbSistema;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        public MetroFramework.Controls.MetroTile btTema;
        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroLabel lbHorario;
        public MetroFramework.Controls.MetroTile btnBiometria;
        public MetroFramework.Controls.MetroTile btnHorario;
        private MetroFramework.Controls.MetroLabel lblUsuario;
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
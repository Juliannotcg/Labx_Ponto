namespace LabxPonto_View.Views.Empresas
{
    partial class frmEmpresaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpresaCadastro));
            this.tcCadastroFuncionario = new MetroFramework.Controls.MetroTabControl();
            this.tpDadosPessoais = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.txtEmailResponsavel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txtCargoResponsavel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txtNomeResponsavel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtInscricao = new MetroFramework.Controls.MetroTextBox();
            this.btCapturar = new MetroFramework.Controls.MetroButton();
            this.metroLabel34 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtFolha = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnLocalizarImg = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.imgFoto = new System.Windows.Forms.PictureBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCNPJ = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbNome = new MetroFramework.Controls.MetroLabel();
            this.txtNomeEmpresa = new MetroFramework.Controls.MetroTextBox();
            this.tpEndereco = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.cbPais = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel37 = new MetroFramework.Controls.MetroLabel();
            this.cmbEstado = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel39 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel38 = new MetroFramework.Controls.MetroLabel();
            this.Cidade = new MetroFramework.Controls.MetroLabel();
            this.metroLabel36 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel35 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel24 = new MetroFramework.Controls.MetroLabel();
            this.txtCidade = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.txtComplemento = new MetroFramework.Controls.MetroTextBox();
            this.txtCEP = new MetroFramework.Controls.MetroTextBox();
            this.txtBairro = new MetroFramework.Controls.MetroTextBox();
            this.txtEndereco = new MetroFramework.Controls.MetroTextBox();
            this.errorProviderEmp = new System.Windows.Forms.ErrorProvider(this.components);
            this.buscarArquivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.tcCadastroFuncionario.SuspendLayout();
            this.tpDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).BeginInit();
            this.tpEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1053, 534);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_2);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(919, 534);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // metroLink1
            // 
            // 
            // tcCadastroFuncionario
            // 
            this.tcCadastroFuncionario.Controls.Add(this.tpDadosPessoais);
            this.tcCadastroFuncionario.Controls.Add(this.tpEndereco);
            this.tcCadastroFuncionario.Location = new System.Drawing.Point(27, 75);
            this.tcCadastroFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcCadastroFuncionario.Name = "tcCadastroFuncionario";
            this.tcCadastroFuncionario.SelectedIndex = 0;
            this.tcCadastroFuncionario.Size = new System.Drawing.Size(1168, 437);
            this.tcCadastroFuncionario.TabIndex = 55;
            this.tcCadastroFuncionario.UseCustomBackColor = true;
            this.tcCadastroFuncionario.UseCustomForeColor = true;
            this.tcCadastroFuncionario.UseSelectable = true;
            // 
            // tpDadosPessoais
            // 
            this.tpDadosPessoais.Controls.Add(this.metroLabel21);
            this.tpDadosPessoais.Controls.Add(this.txtEmailResponsavel);
            this.tpDadosPessoais.Controls.Add(this.metroLabel15);
            this.tpDadosPessoais.Controls.Add(this.txtCargoResponsavel);
            this.tpDadosPessoais.Controls.Add(this.metroLabel14);
            this.tpDadosPessoais.Controls.Add(this.txtNomeResponsavel);
            this.tpDadosPessoais.Controls.Add(this.metroLabel11);
            this.tpDadosPessoais.Controls.Add(this.txtInscricao);
            this.tpDadosPessoais.Controls.Add(this.btCapturar);
            this.tpDadosPessoais.Controls.Add(this.metroLabel34);
            this.tpDadosPessoais.Controls.Add(this.metroLabel26);
            this.tpDadosPessoais.Controls.Add(this.metroLabel20);
            this.tpDadosPessoais.Controls.Add(this.metroLabel19);
            this.tpDadosPessoais.Controls.Add(this.metroLabel22);
            this.tpDadosPessoais.Controls.Add(this.metroLabel18);
            this.tpDadosPessoais.Controls.Add(this.metroLabel17);
            this.tpDadosPessoais.Controls.Add(this.metroLabel16);
            this.tpDadosPessoais.Controls.Add(this.metroLabel13);
            this.tpDadosPessoais.Controls.Add(this.metroLabel12);
            this.tpDadosPessoais.Controls.Add(this.metroLabel10);
            this.tpDadosPessoais.Controls.Add(this.txtFolha);
            this.tpDadosPessoais.Controls.Add(this.metroLabel9);
            this.tpDadosPessoais.Controls.Add(this.metroLabel8);
            this.tpDadosPessoais.Controls.Add(this.metroLabel7);
            this.tpDadosPessoais.Controls.Add(this.metroLabel6);
            this.tpDadosPessoais.Controls.Add(this.btnLocalizarImg);
            this.tpDadosPessoais.Controls.Add(this.metroLabel5);
            this.tpDadosPessoais.Controls.Add(this.imgFoto);
            this.tpDadosPessoais.Controls.Add(this.metroLabel4);
            this.tpDadosPessoais.Controls.Add(this.metroLabel3);
            this.tpDadosPessoais.Controls.Add(this.metroLabel2);
            this.tpDadosPessoais.Controls.Add(this.txtCNPJ);
            this.tpDadosPessoais.Controls.Add(this.metroLabel1);
            this.tpDadosPessoais.Controls.Add(this.lbNome);
            this.tpDadosPessoais.Controls.Add(this.txtNomeEmpresa);
            this.tpDadosPessoais.HorizontalScrollbarBarColor = true;
            this.tpDadosPessoais.HorizontalScrollbarHighlightOnWheel = false;
            this.tpDadosPessoais.HorizontalScrollbarSize = 10;
            this.tpDadosPessoais.Location = new System.Drawing.Point(4, 38);
            this.tpDadosPessoais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpDadosPessoais.Name = "tpDadosPessoais";
            this.tpDadosPessoais.Size = new System.Drawing.Size(1160, 395);
            this.tpDadosPessoais.TabIndex = 0;
            this.tpDadosPessoais.Text = "Dados da Empresa";
            this.tpDadosPessoais.UseCustomBackColor = true;
            this.tpDadosPessoais.UseCustomForeColor = true;
            this.tpDadosPessoais.VerticalScrollbarBarColor = true;
            this.tpDadosPessoais.VerticalScrollbarHighlightOnWheel = false;
            this.tpDadosPessoais.VerticalScrollbarSize = 11;
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(0, 311);
            this.metroLabel21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(48, 20);
            this.metroLabel21.TabIndex = 71;
            this.metroLabel21.Text = "E-mail";
            this.metroLabel21.UseCustomBackColor = true;
            this.metroLabel21.UseCustomForeColor = true;
            // 
            // txtEmailResponsavel
            // 
            // 
            // 
            // 
            this.txtEmailResponsavel.CustomButton.Image = null;
            this.txtEmailResponsavel.CustomButton.Location = new System.Drawing.Point(374, 2);
            this.txtEmailResponsavel.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtEmailResponsavel.CustomButton.Name = "";
            this.txtEmailResponsavel.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtEmailResponsavel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmailResponsavel.CustomButton.TabIndex = 1;
            this.txtEmailResponsavel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmailResponsavel.CustomButton.UseSelectable = true;
            this.txtEmailResponsavel.CustomButton.Visible = false;
            this.txtEmailResponsavel.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEmailResponsavel.Lines = new string[0];
            this.txtEmailResponsavel.Location = new System.Drawing.Point(0, 337);
            this.txtEmailResponsavel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailResponsavel.MaxLength = 32767;
            this.txtEmailResponsavel.Name = "txtEmailResponsavel";
            this.txtEmailResponsavel.PasswordChar = '\0';
            this.txtEmailResponsavel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailResponsavel.SelectedText = "";
            this.txtEmailResponsavel.SelectionLength = 0;
            this.txtEmailResponsavel.SelectionStart = 0;
            this.txtEmailResponsavel.ShortcutsEnabled = true;
            this.txtEmailResponsavel.Size = new System.Drawing.Size(408, 36);
            this.txtEmailResponsavel.TabIndex = 6;
            this.txtEmailResponsavel.UseSelectable = true;
            this.txtEmailResponsavel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmailResponsavel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(435, 242);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(46, 20);
            this.metroLabel15.TabIndex = 69;
            this.metroLabel15.Text = "Cargo";
            this.metroLabel15.UseCustomBackColor = true;
            this.metroLabel15.UseCustomForeColor = true;
            // 
            // txtCargoResponsavel
            // 
            // 
            // 
            // 
            this.txtCargoResponsavel.CustomButton.Image = null;
            this.txtCargoResponsavel.CustomButton.Location = new System.Drawing.Point(277, 2);
            this.txtCargoResponsavel.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCargoResponsavel.CustomButton.Name = "";
            this.txtCargoResponsavel.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtCargoResponsavel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCargoResponsavel.CustomButton.TabIndex = 1;
            this.txtCargoResponsavel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCargoResponsavel.CustomButton.UseSelectable = true;
            this.txtCargoResponsavel.CustomButton.Visible = false;
            this.txtCargoResponsavel.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCargoResponsavel.Lines = new string[0];
            this.txtCargoResponsavel.Location = new System.Drawing.Point(435, 268);
            this.txtCargoResponsavel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCargoResponsavel.MaxLength = 32767;
            this.txtCargoResponsavel.Name = "txtCargoResponsavel";
            this.txtCargoResponsavel.PasswordChar = '\0';
            this.txtCargoResponsavel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCargoResponsavel.SelectedText = "";
            this.txtCargoResponsavel.SelectionLength = 0;
            this.txtCargoResponsavel.SelectionStart = 0;
            this.txtCargoResponsavel.ShortcutsEnabled = true;
            this.txtCargoResponsavel.Size = new System.Drawing.Size(311, 36);
            this.txtCargoResponsavel.TabIndex = 5;
            this.txtCargoResponsavel.UseSelectable = true;
            this.txtCargoResponsavel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCargoResponsavel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(0, 242);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(146, 20);
            this.metroLabel14.TabIndex = 67;
            this.metroLabel14.Text = "Nome do responsável";
            this.metroLabel14.UseCustomBackColor = true;
            this.metroLabel14.UseCustomForeColor = true;
            // 
            // txtNomeResponsavel
            // 
            // 
            // 
            // 
            this.txtNomeResponsavel.CustomButton.Image = null;
            this.txtNomeResponsavel.CustomButton.Location = new System.Drawing.Point(374, 2);
            this.txtNomeResponsavel.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNomeResponsavel.CustomButton.Name = "";
            this.txtNomeResponsavel.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtNomeResponsavel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeResponsavel.CustomButton.TabIndex = 1;
            this.txtNomeResponsavel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeResponsavel.CustomButton.UseSelectable = true;
            this.txtNomeResponsavel.CustomButton.Visible = false;
            this.txtNomeResponsavel.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNomeResponsavel.Lines = new string[0];
            this.txtNomeResponsavel.Location = new System.Drawing.Point(0, 268);
            this.txtNomeResponsavel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeResponsavel.MaxLength = 32767;
            this.txtNomeResponsavel.Name = "txtNomeResponsavel";
            this.txtNomeResponsavel.PasswordChar = '\0';
            this.txtNomeResponsavel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeResponsavel.SelectedText = "";
            this.txtNomeResponsavel.SelectionLength = 0;
            this.txtNomeResponsavel.SelectionStart = 0;
            this.txtNomeResponsavel.ShortcutsEnabled = true;
            this.txtNomeResponsavel.Size = new System.Drawing.Size(408, 36);
            this.txtNomeResponsavel.TabIndex = 4;
            this.txtNomeResponsavel.UseSelectable = true;
            this.txtNomeResponsavel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeResponsavel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(435, 85);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(63, 20);
            this.metroLabel11.TabIndex = 65;
            this.metroLabel11.Text = "Inscrição";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // txtInscricao
            // 
            // 
            // 
            // 
            this.txtInscricao.CustomButton.Image = null;
            this.txtInscricao.CustomButton.Location = new System.Drawing.Point(277, 2);
            this.txtInscricao.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtInscricao.CustomButton.Name = "";
            this.txtInscricao.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtInscricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInscricao.CustomButton.TabIndex = 1;
            this.txtInscricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInscricao.CustomButton.UseSelectable = true;
            this.txtInscricao.CustomButton.Visible = false;
            this.txtInscricao.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtInscricao.Lines = new string[0];
            this.txtInscricao.Location = new System.Drawing.Point(435, 111);
            this.txtInscricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInscricao.MaxLength = 32767;
            this.txtInscricao.Name = "txtInscricao";
            this.txtInscricao.PasswordChar = '\0';
            this.txtInscricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInscricao.SelectedText = "";
            this.txtInscricao.SelectionLength = 0;
            this.txtInscricao.SelectionStart = 0;
            this.txtInscricao.ShortcutsEnabled = true;
            this.txtInscricao.Size = new System.Drawing.Size(311, 36);
            this.txtInscricao.TabIndex = 2;
            this.txtInscricao.UseSelectable = true;
            this.txtInscricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInscricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btCapturar
            // 
            this.btCapturar.Location = new System.Drawing.Point(999, 194);
            this.btCapturar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCapturar.Name = "btCapturar";
            this.btCapturar.Size = new System.Drawing.Size(97, 74);
            this.btCapturar.TabIndex = 63;
            this.btCapturar.Text = "Capturar";
            this.btCapturar.UseSelectable = true;
            this.btCapturar.Click += new System.EventHandler(this.btCapturar_Click);
            // 
            // metroLabel34
            // 
            this.metroLabel34.AutoSize = true;
            this.metroLabel34.Location = new System.Drawing.Point(823, 85);
            this.metroLabel34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel34.Name = "metroLabel34";
            this.metroLabel34.Size = new System.Drawing.Size(94, 20);
            this.metroLabel34.TabIndex = 62;
            this.metroLabel34.Text = "Imagem Logo";
            this.metroLabel34.UseCustomBackColor = true;
            this.metroLabel34.UseCustomForeColor = true;
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Location = new System.Drawing.Point(0, 149);
            this.metroLabel26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(41, 20);
            this.metroLabel26.TabIndex = 52;
            this.metroLabel26.Text = "CNPJ";
            this.metroLabel26.UseCustomBackColor = true;
            this.metroLabel26.UseCustomForeColor = true;
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(0, 85);
            this.metroLabel20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(63, 20);
            this.metroLabel20.TabIndex = 50;
            this.metroLabel20.Text = "Empresa";
            this.metroLabel20.UseCustomBackColor = true;
            this.metroLabel20.UseCustomForeColor = true;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(0, 21);
            this.metroLabel19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(63, 20);
            this.metroLabel19.TabIndex = 49;
            this.metroLabel19.Text = "Nº Folha";
            this.metroLabel19.UseCustomBackColor = true;
            this.metroLabel19.UseCustomForeColor = true;
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel22.Location = new System.Drawing.Point(299, 21);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(0, 0);
            this.metroLabel22.TabIndex = 46;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(0, 448);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(0, 0);
            this.metroLabel18.TabIndex = 39;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(0, 576);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(0, 0);
            this.metroLabel17.TabIndex = 37;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(0, 512);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(0, 0);
            this.metroLabel16.TabIndex = 35;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(456, 213);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(0, 0);
            this.metroLabel13.TabIndex = 29;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(413, 172);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(0, 0);
            this.metroLabel12.TabIndex = 27;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(0, 21);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(0, 0);
            this.metroLabel10.TabIndex = 24;
            // 
            // txtFolha
            // 
            // 
            // 
            // 
            this.txtFolha.CustomButton.Image = null;
            this.txtFolha.CustomButton.Location = new System.Drawing.Point(51, 2);
            this.txtFolha.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtFolha.CustomButton.Name = "";
            this.txtFolha.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtFolha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFolha.CustomButton.TabIndex = 1;
            this.txtFolha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFolha.CustomButton.UseSelectable = true;
            this.txtFolha.CustomButton.Visible = false;
            this.txtFolha.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtFolha.Lines = new string[0];
            this.txtFolha.Location = new System.Drawing.Point(0, 47);
            this.txtFolha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFolha.MaxLength = 20;
            this.txtFolha.Name = "txtFolha";
            this.txtFolha.PasswordChar = '\0';
            this.txtFolha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFolha.SelectedText = "";
            this.txtFolha.SelectionLength = 0;
            this.txtFolha.SelectionStart = 0;
            this.txtFolha.ShortcutsEnabled = true;
            this.txtFolha.Size = new System.Drawing.Size(85, 36);
            this.txtFolha.TabIndex = 0;
            this.txtFolha.UseSelectable = true;
            this.txtFolha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFolha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(0, 341);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(0, 0);
            this.metroLabel9.TabIndex = 22;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(0, 277);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(0, 0);
            this.metroLabel8.TabIndex = 20;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(199, 213);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(0, 0);
            this.metroLabel7.TabIndex = 18;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(456, 149);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(0, 0);
            this.metroLabel6.TabIndex = 16;
            // 
            // btnLocalizarImg
            // 
            this.btnLocalizarImg.Location = new System.Drawing.Point(999, 111);
            this.btnLocalizarImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLocalizarImg.Name = "btnLocalizarImg";
            this.btnLocalizarImg.Size = new System.Drawing.Size(97, 76);
            this.btnLocalizarImg.TabIndex = 14;
            this.btnLocalizarImg.Text = "Localizar";
            this.btnLocalizarImg.UseSelectable = true;
            this.btnLocalizarImg.Click += new System.EventHandler(this.btnLocalizarImg_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(963, 66);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(0, 0);
            this.metroLabel5.TabIndex = 13;
            // 
            // imgFoto
            // 
            this.imgFoto.Location = new System.Drawing.Point(823, 111);
            this.imgFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgFoto.Name = "imgFoto";
            this.imgFoto.Size = new System.Drawing.Size(171, 158);
            this.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFoto.TabIndex = 12;
            this.imgFoto.TabStop = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(0, 213);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(0, 0);
            this.metroLabel4.TabIndex = 11;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(199, 149);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(0, 0);
            this.metroLabel3.TabIndex = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(0, 149);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(0, 0);
            this.metroLabel2.TabIndex = 7;
            // 
            // txtCNPJ
            // 
            // 
            // 
            // 
            this.txtCNPJ.CustomButton.Image = null;
            this.txtCNPJ.CustomButton.Location = new System.Drawing.Point(374, 2);
            this.txtCNPJ.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCNPJ.CustomButton.Name = "";
            this.txtCNPJ.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtCNPJ.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCNPJ.CustomButton.TabIndex = 1;
            this.txtCNPJ.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCNPJ.CustomButton.UseSelectable = true;
            this.txtCNPJ.CustomButton.Visible = false;
            this.txtCNPJ.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCNPJ.Lines = new string[0];
            this.txtCNPJ.Location = new System.Drawing.Point(0, 175);
            this.txtCNPJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCNPJ.MaxLength = 14;
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.PasswordChar = '\0';
            this.txtCNPJ.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCNPJ.SelectedText = "";
            this.txtCNPJ.SelectionLength = 0;
            this.txtCNPJ.SelectionStart = 0;
            this.txtCNPJ.ShortcutsEnabled = true;
            this.txtCNPJ.Size = new System.Drawing.Size(408, 36);
            this.txtCNPJ.TabIndex = 3;
            this.txtCNPJ.UseSelectable = true;
            this.txtCNPJ.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCNPJ.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCNPJ.Leave += new System.EventHandler(this.txtCNPJ_Leave);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(456, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 5;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(0, 85);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(0, 0);
            this.lbNome.TabIndex = 3;
            // 
            // txtNomeEmpresa
            // 
            // 
            // 
            // 
            this.txtNomeEmpresa.CustomButton.Image = null;
            this.txtNomeEmpresa.CustomButton.Location = new System.Drawing.Point(374, 2);
            this.txtNomeEmpresa.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNomeEmpresa.CustomButton.Name = "";
            this.txtNomeEmpresa.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtNomeEmpresa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeEmpresa.CustomButton.TabIndex = 1;
            this.txtNomeEmpresa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeEmpresa.CustomButton.UseSelectable = true;
            this.txtNomeEmpresa.CustomButton.Visible = false;
            this.txtNomeEmpresa.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNomeEmpresa.Lines = new string[0];
            this.txtNomeEmpresa.Location = new System.Drawing.Point(0, 111);
            this.txtNomeEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeEmpresa.MaxLength = 32767;
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.PasswordChar = '\0';
            this.txtNomeEmpresa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeEmpresa.SelectedText = "";
            this.txtNomeEmpresa.SelectionLength = 0;
            this.txtNomeEmpresa.SelectionStart = 0;
            this.txtNomeEmpresa.ShortcutsEnabled = true;
            this.txtNomeEmpresa.Size = new System.Drawing.Size(408, 36);
            this.txtNomeEmpresa.TabIndex = 1;
            this.txtNomeEmpresa.UseSelectable = true;
            this.txtNomeEmpresa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeEmpresa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tpEndereco
            // 
            this.tpEndereco.Controls.Add(this.metroLabel27);
            this.tpEndereco.Controls.Add(this.cbPais);
            this.tpEndereco.Controls.Add(this.metroLabel37);
            this.tpEndereco.Controls.Add(this.cmbEstado);
            this.tpEndereco.Controls.Add(this.metroLabel39);
            this.tpEndereco.Controls.Add(this.metroLabel38);
            this.tpEndereco.Controls.Add(this.Cidade);
            this.tpEndereco.Controls.Add(this.metroLabel36);
            this.tpEndereco.Controls.Add(this.metroLabel35);
            this.tpEndereco.Controls.Add(this.metroLabel23);
            this.tpEndereco.Controls.Add(this.metroLabel24);
            this.tpEndereco.Controls.Add(this.txtCidade);
            this.tpEndereco.Controls.Add(this.metroLabel25);
            this.tpEndereco.Controls.Add(this.txtComplemento);
            this.tpEndereco.Controls.Add(this.txtCEP);
            this.tpEndereco.Controls.Add(this.txtBairro);
            this.tpEndereco.Controls.Add(this.txtEndereco);
            this.tpEndereco.HorizontalScrollbarBarColor = true;
            this.tpEndereco.HorizontalScrollbarHighlightOnWheel = false;
            this.tpEndereco.HorizontalScrollbarSize = 10;
            this.tpEndereco.Location = new System.Drawing.Point(4, 38);
            this.tpEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpEndereco.Name = "tpEndereco";
            this.tpEndereco.Size = new System.Drawing.Size(1160, 395);
            this.tpEndereco.TabIndex = 1;
            this.tpEndereco.Text = "Endereço";
            this.tpEndereco.UseCustomBackColor = true;
            this.tpEndereco.UseCustomForeColor = true;
            this.tpEndereco.VerticalScrollbarBarColor = true;
            this.tpEndereco.VerticalScrollbarHighlightOnWheel = false;
            this.tpEndereco.VerticalScrollbarSize = 11;
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.Location = new System.Drawing.Point(753, 153);
            this.metroLabel27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(32, 20);
            this.metroLabel27.TabIndex = 63;
            this.metroLabel27.Text = "País";
            this.metroLabel27.UseCustomBackColor = true;
            this.metroLabel27.UseCustomForeColor = true;
            // 
            // cbPais
            // 
            this.cbPais.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.ItemHeight = 29;
            this.cbPais.Location = new System.Drawing.Point(753, 177);
            this.cbPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(245, 35);
            this.cbPais.TabIndex = 6;
            this.cbPais.UseSelectable = true;
            // 
            // metroLabel37
            // 
            this.metroLabel37.AutoSize = true;
            this.metroLabel37.Location = new System.Drawing.Point(753, 86);
            this.metroLabel37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel37.Name = "metroLabel37";
            this.metroLabel37.Size = new System.Drawing.Size(50, 20);
            this.metroLabel37.TabIndex = 61;
            this.metroLabel37.Text = "Estado";
            this.metroLabel37.UseCustomBackColor = true;
            this.metroLabel37.UseCustomForeColor = true;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.ItemHeight = 29;
            this.cmbEstado.Location = new System.Drawing.Point(753, 110);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(245, 35);
            this.cmbEstado.TabIndex = 3;
            this.cmbEstado.UseSelectable = true;
            // 
            // metroLabel39
            // 
            this.metroLabel39.AutoSize = true;
            this.metroLabel39.Location = new System.Drawing.Point(225, 151);
            this.metroLabel39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel39.Name = "metroLabel39";
            this.metroLabel39.Size = new System.Drawing.Size(97, 20);
            this.metroLabel39.TabIndex = 59;
            this.metroLabel39.Text = "Complemento";
            this.metroLabel39.UseCustomBackColor = true;
            this.metroLabel39.UseCustomForeColor = true;
            // 
            // metroLabel38
            // 
            this.metroLabel38.AutoSize = true;
            this.metroLabel38.Location = new System.Drawing.Point(0, 151);
            this.metroLabel38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel38.Name = "metroLabel38";
            this.metroLabel38.Size = new System.Drawing.Size(45, 20);
            this.metroLabel38.TabIndex = 58;
            this.metroLabel38.Text = "Bairro";
            this.metroLabel38.UseCustomBackColor = true;
            this.metroLabel38.UseCustomForeColor = true;
            // 
            // Cidade
            // 
            this.Cidade.AutoSize = true;
            this.Cidade.Location = new System.Drawing.Point(465, 87);
            this.Cidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(52, 20);
            this.Cidade.TabIndex = 57;
            this.Cidade.Text = "Cidade";
            this.Cidade.UseCustomBackColor = true;
            this.Cidade.UseCustomForeColor = true;
            // 
            // metroLabel36
            // 
            this.metroLabel36.AutoSize = true;
            this.metroLabel36.Location = new System.Drawing.Point(0, 87);
            this.metroLabel36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel36.Name = "metroLabel36";
            this.metroLabel36.Size = new System.Drawing.Size(69, 20);
            this.metroLabel36.TabIndex = 56;
            this.metroLabel36.Text = "Endereço";
            this.metroLabel36.UseCustomBackColor = true;
            this.metroLabel36.UseCustomForeColor = true;
            // 
            // metroLabel35
            // 
            this.metroLabel35.AutoSize = true;
            this.metroLabel35.Location = new System.Drawing.Point(0, 18);
            this.metroLabel35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel35.Name = "metroLabel35";
            this.metroLabel35.Size = new System.Drawing.Size(34, 20);
            this.metroLabel35.TabIndex = 0;
            this.metroLabel35.Text = "CEP";
            this.metroLabel35.UseCustomBackColor = true;
            this.metroLabel35.UseCustomForeColor = true;
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.Location = new System.Drawing.Point(465, 177);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(0, 0);
            this.metroLabel23.TabIndex = 54;
            // 
            // metroLabel24
            // 
            this.metroLabel24.AutoSize = true;
            this.metroLabel24.Location = new System.Drawing.Point(465, 113);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(0, 0);
            this.metroLabel24.TabIndex = 52;
            // 
            // txtCidade
            // 
            // 
            // 
            // 
            this.txtCidade.CustomButton.Image = null;
            this.txtCidade.CustomButton.Location = new System.Drawing.Point(219, 2);
            this.txtCidade.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCidade.CustomButton.Name = "";
            this.txtCidade.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtCidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCidade.CustomButton.TabIndex = 1;
            this.txtCidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCidade.CustomButton.UseSelectable = true;
            this.txtCidade.CustomButton.Visible = false;
            this.txtCidade.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCidade.Lines = new string[0];
            this.txtCidade.Location = new System.Drawing.Point(465, 113);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCidade.MaxLength = 32767;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.PasswordChar = '\0';
            this.txtCidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCidade.SelectedText = "";
            this.txtCidade.SelectionLength = 0;
            this.txtCidade.SelectionStart = 0;
            this.txtCidade.ShortcutsEnabled = true;
            this.txtCidade.Size = new System.Drawing.Size(253, 36);
            this.txtCidade.TabIndex = 2;
            this.txtCidade.UseSelectable = true;
            this.txtCidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.Location = new System.Drawing.Point(235, 177);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(0, 0);
            this.metroLabel25.TabIndex = 50;
            // 
            // txtComplemento
            // 
            // 
            // 
            // 
            this.txtComplemento.CustomButton.Image = null;
            this.txtComplemento.CustomButton.Location = new System.Drawing.Point(459, 2);
            this.txtComplemento.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtComplemento.CustomButton.Name = "";
            this.txtComplemento.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtComplemento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtComplemento.CustomButton.TabIndex = 1;
            this.txtComplemento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtComplemento.CustomButton.UseSelectable = true;
            this.txtComplemento.CustomButton.Visible = false;
            this.txtComplemento.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtComplemento.Lines = new string[0];
            this.txtComplemento.Location = new System.Drawing.Point(225, 177);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComplemento.MaxLength = 32767;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.PasswordChar = '\0';
            this.txtComplemento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComplemento.SelectedText = "";
            this.txtComplemento.SelectionLength = 0;
            this.txtComplemento.SelectionStart = 0;
            this.txtComplemento.ShortcutsEnabled = true;
            this.txtComplemento.Size = new System.Drawing.Size(493, 36);
            this.txtComplemento.TabIndex = 5;
            this.txtComplemento.UseSelectable = true;
            this.txtComplemento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtComplemento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCEP
            // 
            // 
            // 
            // 
            this.txtCEP.CustomButton.Image = null;
            this.txtCEP.CustomButton.Location = new System.Drawing.Point(111, 2);
            this.txtCEP.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCEP.CustomButton.Name = "";
            this.txtCEP.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtCEP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCEP.CustomButton.TabIndex = 1;
            this.txtCEP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCEP.CustomButton.UseSelectable = true;
            this.txtCEP.CustomButton.Visible = false;
            this.txtCEP.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCEP.Lines = new string[0];
            this.txtCEP.Location = new System.Drawing.Point(0, 46);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCEP.MaxLength = 8;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.PasswordChar = '\0';
            this.txtCEP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCEP.SelectedText = "";
            this.txtCEP.SelectionLength = 0;
            this.txtCEP.SelectionStart = 0;
            this.txtCEP.ShortcutsEnabled = true;
            this.txtCEP.Size = new System.Drawing.Size(145, 36);
            this.txtCEP.TabIndex = 0;
            this.txtCEP.UseSelectable = true;
            this.txtCEP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCEP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
            // 
            // txtBairro
            // 
            // 
            // 
            // 
            this.txtBairro.CustomButton.Image = null;
            this.txtBairro.CustomButton.Location = new System.Drawing.Point(163, 2);
            this.txtBairro.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtBairro.CustomButton.Name = "";
            this.txtBairro.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtBairro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBairro.CustomButton.TabIndex = 1;
            this.txtBairro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBairro.CustomButton.UseSelectable = true;
            this.txtBairro.CustomButton.Visible = false;
            this.txtBairro.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBairro.Lines = new string[0];
            this.txtBairro.Location = new System.Drawing.Point(0, 177);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBairro.MaxLength = 32767;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBairro.SelectedText = "";
            this.txtBairro.SelectionLength = 0;
            this.txtBairro.SelectionStart = 0;
            this.txtBairro.ShortcutsEnabled = true;
            this.txtBairro.Size = new System.Drawing.Size(197, 36);
            this.txtBairro.TabIndex = 4;
            this.txtBairro.UseSelectable = true;
            this.txtBairro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBairro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEndereco
            // 
            // 
            // 
            // 
            this.txtEndereco.CustomButton.Image = null;
            this.txtEndereco.CustomButton.Location = new System.Drawing.Point(395, 2);
            this.txtEndereco.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtEndereco.CustomButton.Name = "";
            this.txtEndereco.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtEndereco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEndereco.CustomButton.TabIndex = 1;
            this.txtEndereco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEndereco.CustomButton.UseSelectable = true;
            this.txtEndereco.CustomButton.Visible = false;
            this.txtEndereco.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEndereco.Lines = new string[0];
            this.txtEndereco.Location = new System.Drawing.Point(0, 113);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEndereco.MaxLength = 32767;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.PasswordChar = '\0';
            this.txtEndereco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEndereco.SelectedText = "";
            this.txtEndereco.SelectionLength = 0;
            this.txtEndereco.SelectionStart = 0;
            this.txtEndereco.ShortcutsEnabled = true;
            this.txtEndereco.Size = new System.Drawing.Size(429, 36);
            this.txtEndereco.TabIndex = 1;
            this.txtEndereco.UseSelectable = true;
            this.txtEndereco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEndereco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // errorProviderEmp
            // 
            this.errorProviderEmp.ContainerControl = this;
            this.errorProviderEmp.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderEmp.Icon")));
            // 
            // frmEmpresaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 606);
            this.Controls.Add(this.tcCadastroFuncionario);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmEmpresaCadastro";
            this.Padding = new System.Windows.Forms.Padding(36, 91, 36, 31);
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.frmEmpresaCadastro_Load);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.tcCadastroFuncionario, 0);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.tcCadastroFuncionario.ResumeLayout(false);
            this.tpDadosPessoais.ResumeLayout(false);
            this.tpDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).EndInit();
            this.tpEndereco.ResumeLayout(false);
            this.tpEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tcCadastroFuncionario;
        private MetroFramework.Controls.MetroTabPage tpDadosPessoais;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroTextBox txtEmailResponsavel;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox txtCargoResponsavel;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txtNomeResponsavel;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtInscricao;
        private MetroFramework.Controls.MetroButton btCapturar;
        private MetroFramework.Controls.MetroLabel metroLabel34;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtFolha;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btnLocalizarImg;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.PictureBox imgFoto;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtCNPJ;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbNome;
        private MetroFramework.Controls.MetroTextBox txtNomeEmpresa;
        private MetroFramework.Controls.MetroTabPage tpEndereco;
        private MetroFramework.Controls.MetroLabel metroLabel37;
        private MetroFramework.Controls.MetroComboBox cmbEstado;
        private MetroFramework.Controls.MetroLabel metroLabel39;
        private MetroFramework.Controls.MetroLabel metroLabel38;
        private MetroFramework.Controls.MetroLabel Cidade;
        private MetroFramework.Controls.MetroLabel metroLabel36;
        private MetroFramework.Controls.MetroLabel metroLabel35;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroLabel metroLabel24;
        private MetroFramework.Controls.MetroTextBox txtCidade;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        private MetroFramework.Controls.MetroTextBox txtComplemento;
        private MetroFramework.Controls.MetroTextBox txtCEP;
        private MetroFramework.Controls.MetroTextBox txtBairro;
        private MetroFramework.Controls.MetroTextBox txtEndereco;
        private MetroFramework.Controls.MetroLabel metroLabel27;
        private MetroFramework.Controls.MetroComboBox cbPais;
        private System.Windows.Forms.ErrorProvider errorProviderEmp;
        private System.Windows.Forms.OpenFileDialog buscarArquivo;
    }
}
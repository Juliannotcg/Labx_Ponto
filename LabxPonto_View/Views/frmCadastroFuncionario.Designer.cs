namespace LabxPonto_View.Forms
{
    partial class frmCadastroFuncionario
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
            this.tcCadastroFuncionario = new MetroFramework.Controls.MetroTabControl();
            this.tpDadosPessoais = new MetroFramework.Controls.MetroTabPage();
            this.btnLocalizarImg = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtRG = new MetroFramework.Controls.MetroTextBox();
            this.dtDataNascimento = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCPF = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSobreNome = new MetroFramework.Controls.MetroTextBox();
            this.lbNome = new MetroFramework.Controls.MetroLabel();
            this.txtNomeFuncionario = new MetroFramework.Controls.MetroTextBox();
            this.tpEndereco = new MetroFramework.Controls.MetroTabPage();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.imgFoto = new System.Windows.Forms.PictureBox();
            this.cbEstadoCivil = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtTelefone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtNomePai = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtNomeMae = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.tcCadastroFuncionario.SuspendLayout();
            this.tpDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCadastroFuncionario
            // 
            this.tcCadastroFuncionario.Controls.Add(this.tpDadosPessoais);
            this.tcCadastroFuncionario.Controls.Add(this.tpEndereco);
            this.tcCadastroFuncionario.Location = new System.Drawing.Point(24, 74);
            this.tcCadastroFuncionario.Name = "tcCadastroFuncionario";
            this.tcCadastroFuncionario.SelectedIndex = 0;
            this.tcCadastroFuncionario.Size = new System.Drawing.Size(973, 608);
            this.tcCadastroFuncionario.TabIndex = 0;
            this.tcCadastroFuncionario.UseSelectable = true;
            // 
            // tpDadosPessoais
            // 
            this.tpDadosPessoais.Controls.Add(this.metroLabel10);
            this.tpDadosPessoais.Controls.Add(this.metroTextBox1);
            this.tpDadosPessoais.Controls.Add(this.metroLabel9);
            this.tpDadosPessoais.Controls.Add(this.txtNomeMae);
            this.tpDadosPessoais.Controls.Add(this.metroLabel8);
            this.tpDadosPessoais.Controls.Add(this.txtNomePai);
            this.tpDadosPessoais.Controls.Add(this.metroLabel7);
            this.tpDadosPessoais.Controls.Add(this.txtTelefone);
            this.tpDadosPessoais.Controls.Add(this.metroLabel6);
            this.tpDadosPessoais.Controls.Add(this.cbEstadoCivil);
            this.tpDadosPessoais.Controls.Add(this.btnCancelar);
            this.tpDadosPessoais.Controls.Add(this.btnSalvar);
            this.tpDadosPessoais.Controls.Add(this.btnLocalizarImg);
            this.tpDadosPessoais.Controls.Add(this.metroLabel5);
            this.tpDadosPessoais.Controls.Add(this.imgFoto);
            this.tpDadosPessoais.Controls.Add(this.metroLabel4);
            this.tpDadosPessoais.Controls.Add(this.metroLabel3);
            this.tpDadosPessoais.Controls.Add(this.txtRG);
            this.tpDadosPessoais.Controls.Add(this.dtDataNascimento);
            this.tpDadosPessoais.Controls.Add(this.metroLabel2);
            this.tpDadosPessoais.Controls.Add(this.txtCPF);
            this.tpDadosPessoais.Controls.Add(this.metroLabel1);
            this.tpDadosPessoais.Controls.Add(this.txtSobreNome);
            this.tpDadosPessoais.Controls.Add(this.lbNome);
            this.tpDadosPessoais.Controls.Add(this.txtNomeFuncionario);
            this.tpDadosPessoais.HorizontalScrollbarBarColor = true;
            this.tpDadosPessoais.HorizontalScrollbarHighlightOnWheel = false;
            this.tpDadosPessoais.HorizontalScrollbarSize = 10;
            this.tpDadosPessoais.Location = new System.Drawing.Point(4, 38);
            this.tpDadosPessoais.Name = "tpDadosPessoais";
            this.tpDadosPessoais.Size = new System.Drawing.Size(965, 566);
            this.tpDadosPessoais.TabIndex = 0;
            this.tpDadosPessoais.Text = "Cadastro de Funcionários";
            this.tpDadosPessoais.VerticalScrollbarBarColor = true;
            this.tpDadosPessoais.VerticalScrollbarHighlightOnWheel = false;
            this.tpDadosPessoais.VerticalScrollbarSize = 10;
            // 
            // btnLocalizarImg
            // 
            this.btnLocalizarImg.Location = new System.Drawing.Point(781, 254);
            this.btnLocalizarImg.Name = "btnLocalizarImg";
            this.btnLocalizarImg.Size = new System.Drawing.Size(170, 28);
            this.btnLocalizarImg.TabIndex = 14;
            this.btnLocalizarImg.Text = "Localizar";
            this.btnLocalizarImg.UseSelectable = true;
            this.btnLocalizarImg.Click += new System.EventHandler(this.btnLocalizarImg_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(781, 68);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(36, 20);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Foto";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(0, 166);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(135, 20);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Data de Nascimento";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(198, 117);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(27, 20);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "RG";
            // 
            // txtRG
            // 
            // 
            // 
            // 
            this.txtRG.CustomButton.Image = null;
            this.txtRG.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.txtRG.CustomButton.Name = "";
            this.txtRG.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRG.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRG.CustomButton.TabIndex = 1;
            this.txtRG.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRG.CustomButton.UseSelectable = true;
            this.txtRG.CustomButton.Visible = false;
            this.txtRG.Lines = new string[0];
            this.txtRG.Location = new System.Drawing.Point(198, 140);
            this.txtRG.MaxLength = 32767;
            this.txtRG.Name = "txtRG";
            this.txtRG.PasswordChar = '\0';
            this.txtRG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRG.SelectedText = "";
            this.txtRG.SelectionLength = 0;
            this.txtRG.SelectionStart = 0;
            this.txtRG.ShortcutsEnabled = true;
            this.txtRG.Size = new System.Drawing.Size(213, 23);
            this.txtRG.TabIndex = 9;
            this.txtRG.UseSelectable = true;
            this.txtRG.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRG.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtDataNascimento
            // 
            this.dtDataNascimento.Location = new System.Drawing.Point(3, 189);
            this.dtDataNascimento.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtDataNascimento.Name = "dtDataNascimento";
            this.dtDataNascimento.Size = new System.Drawing.Size(189, 30);
            this.dtDataNascimento.TabIndex = 8;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(33, 20);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "CPF";
            // 
            // txtCPF
            // 
            // 
            // 
            // 
            this.txtCPF.CustomButton.Image = null;
            this.txtCPF.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txtCPF.CustomButton.Name = "";
            this.txtCPF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCPF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCPF.CustomButton.TabIndex = 1;
            this.txtCPF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCPF.CustomButton.UseSelectable = true;
            this.txtCPF.CustomButton.Visible = false;
            this.txtCPF.Lines = new string[0];
            this.txtCPF.Location = new System.Drawing.Point(3, 140);
            this.txtCPF.MaxLength = 32767;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.PasswordChar = '\0';
            this.txtCPF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCPF.SelectedText = "";
            this.txtCPF.SelectionLength = 0;
            this.txtCPF.SelectionStart = 0;
            this.txtCPF.ShortcutsEnabled = true;
            this.txtCPF.Size = new System.Drawing.Size(189, 23);
            this.txtCPF.TabIndex = 6;
            this.txtCPF.UseSelectable = true;
            this.txtCPF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCPF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(414, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 20);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Sobre Nome";
            // 
            // txtSobreNome
            // 
            // 
            // 
            // 
            this.txtSobreNome.CustomButton.Image = null;
            this.txtSobreNome.CustomButton.Location = new System.Drawing.Point(306, 1);
            this.txtSobreNome.CustomButton.Name = "";
            this.txtSobreNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSobreNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSobreNome.CustomButton.TabIndex = 1;
            this.txtSobreNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSobreNome.CustomButton.UseSelectable = true;
            this.txtSobreNome.CustomButton.Visible = false;
            this.txtSobreNome.Lines = new string[0];
            this.txtSobreNome.Location = new System.Drawing.Point(418, 91);
            this.txtSobreNome.MaxLength = 32767;
            this.txtSobreNome.Name = "txtSobreNome";
            this.txtSobreNome.PasswordChar = '\0';
            this.txtSobreNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSobreNome.SelectedText = "";
            this.txtSobreNome.SelectionLength = 0;
            this.txtSobreNome.SelectionStart = 0;
            this.txtSobreNome.ShortcutsEnabled = true;
            this.txtSobreNome.Size = new System.Drawing.Size(328, 23);
            this.txtSobreNome.TabIndex = 4;
            this.txtSobreNome.UseSelectable = true;
            this.txtSobreNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSobreNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(0, 66);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(48, 20);
            this.lbNome.TabIndex = 3;
            this.lbNome.Text = "Nome";
            // 
            // txtNomeFuncionario
            // 
            // 
            // 
            // 
            this.txtNomeFuncionario.CustomButton.Image = null;
            this.txtNomeFuncionario.CustomButton.Location = new System.Drawing.Point(386, 1);
            this.txtNomeFuncionario.CustomButton.Name = "";
            this.txtNomeFuncionario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomeFuncionario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeFuncionario.CustomButton.TabIndex = 1;
            this.txtNomeFuncionario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeFuncionario.CustomButton.UseSelectable = true;
            this.txtNomeFuncionario.CustomButton.Visible = false;
            this.txtNomeFuncionario.Lines = new string[0];
            this.txtNomeFuncionario.Location = new System.Drawing.Point(4, 91);
            this.txtNomeFuncionario.MaxLength = 32767;
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.PasswordChar = '\0';
            this.txtNomeFuncionario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeFuncionario.SelectedText = "";
            this.txtNomeFuncionario.SelectionLength = 0;
            this.txtNomeFuncionario.SelectionStart = 0;
            this.txtNomeFuncionario.ShortcutsEnabled = true;
            this.txtNomeFuncionario.Size = new System.Drawing.Size(408, 23);
            this.txtNomeFuncionario.TabIndex = 2;
            this.txtNomeFuncionario.UseSelectable = true;
            this.txtNomeFuncionario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeFuncionario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tpEndereco
            // 
            this.tpEndereco.HorizontalScrollbarBarColor = true;
            this.tpEndereco.HorizontalScrollbarHighlightOnWheel = false;
            this.tpEndereco.HorizontalScrollbarSize = 10;
            this.tpEndereco.Location = new System.Drawing.Point(4, 38);
            this.tpEndereco.Name = "tpEndereco";
            this.tpEndereco.Size = new System.Drawing.Size(965, 566);
            this.tpEndereco.TabIndex = 1;
            this.tpEndereco.Text = "Cadastro de Empresa";
            this.tpEndereco.VerticalScrollbarBarColor = true;
            this.tpEndereco.VerticalScrollbarHighlightOnWheel = false;
            this.tpEndereco.VerticalScrollbarSize = 10;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(11, 523);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(125, 40);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseSelectable = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(142, 523);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 40);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // imgFoto
            // 
            this.imgFoto.Image = global::LabxPonto_View.Properties.Resources.add_user_icon;
            this.imgFoto.Location = new System.Drawing.Point(781, 91);
            this.imgFoto.Name = "imgFoto";
            this.imgFoto.Size = new System.Drawing.Size(170, 157);
            this.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFoto.TabIndex = 12;
            this.imgFoto.TabStop = false;
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.ItemHeight = 24;
            this.cbEstadoCivil.Location = new System.Drawing.Point(418, 140);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(328, 30);
            this.cbEstadoCivil.TabIndex = 15;
            this.cbEstadoCivil.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(414, 117);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(79, 20);
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = "Estado Civil";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(198, 166);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(62, 20);
            this.metroLabel7.TabIndex = 18;
            this.metroLabel7.Text = "Telefone";
            // 
            // txtTelefone
            // 
            // 
            // 
            // 
            this.txtTelefone.CustomButton.Image = null;
            this.txtTelefone.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.txtTelefone.CustomButton.Name = "";
            this.txtTelefone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelefone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelefone.CustomButton.TabIndex = 1;
            this.txtTelefone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelefone.CustomButton.UseSelectable = true;
            this.txtTelefone.CustomButton.Visible = false;
            this.txtTelefone.Lines = new string[0];
            this.txtTelefone.Location = new System.Drawing.Point(198, 189);
            this.txtTelefone.MaxLength = 32767;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PasswordChar = '\0';
            this.txtTelefone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefone.SelectedText = "";
            this.txtTelefone.SelectionLength = 0;
            this.txtTelefone.SelectionStart = 0;
            this.txtTelefone.ShortcutsEnabled = true;
            this.txtTelefone.Size = new System.Drawing.Size(213, 23);
            this.txtTelefone.TabIndex = 17;
            this.txtTelefone.UseSelectable = true;
            this.txtTelefone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelefone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(0, 222);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(89, 20);
            this.metroLabel8.TabIndex = 20;
            this.metroLabel8.Text = "Nome do Pai";
            // 
            // txtNomePai
            // 
            // 
            // 
            // 
            this.txtNomePai.CustomButton.Image = null;
            this.txtNomePai.CustomButton.Location = new System.Drawing.Point(386, 1);
            this.txtNomePai.CustomButton.Name = "";
            this.txtNomePai.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomePai.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomePai.CustomButton.TabIndex = 1;
            this.txtNomePai.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomePai.CustomButton.UseSelectable = true;
            this.txtNomePai.CustomButton.Visible = false;
            this.txtNomePai.Lines = new string[0];
            this.txtNomePai.Location = new System.Drawing.Point(4, 247);
            this.txtNomePai.MaxLength = 32767;
            this.txtNomePai.Name = "txtNomePai";
            this.txtNomePai.PasswordChar = '\0';
            this.txtNomePai.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomePai.SelectedText = "";
            this.txtNomePai.SelectionLength = 0;
            this.txtNomePai.SelectionStart = 0;
            this.txtNomePai.ShortcutsEnabled = true;
            this.txtNomePai.Size = new System.Drawing.Size(408, 23);
            this.txtNomePai.TabIndex = 19;
            this.txtNomePai.UseSelectable = true;
            this.txtNomePai.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomePai.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(0, 273);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(98, 20);
            this.metroLabel9.TabIndex = 22;
            this.metroLabel9.Text = "Nome da Mãe";
            // 
            // txtNomeMae
            // 
            // 
            // 
            // 
            this.txtNomeMae.CustomButton.Image = null;
            this.txtNomeMae.CustomButton.Location = new System.Drawing.Point(386, 1);
            this.txtNomeMae.CustomButton.Name = "";
            this.txtNomeMae.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomeMae.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeMae.CustomButton.TabIndex = 1;
            this.txtNomeMae.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeMae.CustomButton.UseSelectable = true;
            this.txtNomeMae.CustomButton.Visible = false;
            this.txtNomeMae.Lines = new string[0];
            this.txtNomeMae.Location = new System.Drawing.Point(4, 298);
            this.txtNomeMae.MaxLength = 32767;
            this.txtNomeMae.Name = "txtNomeMae";
            this.txtNomeMae.PasswordChar = '\0';
            this.txtNomeMae.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeMae.SelectedText = "";
            this.txtNomeMae.SelectionLength = 0;
            this.txtNomeMae.SelectionStart = 0;
            this.txtNomeMae.ShortcutsEnabled = true;
            this.txtNomeMae.Size = new System.Drawing.Size(408, 23);
            this.txtNomeMae.TabIndex = 21;
            this.txtNomeMae.UseSelectable = true;
            this.txtNomeMae.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeMae.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(0, 15);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(63, 20);
            this.metroLabel10.TabIndex = 24;
            this.metroLabel10.Text = "Nº Folha";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(63, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(4, 40);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(85, 23);
            this.metroTextBox1.TabIndex = 23;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 705);
            this.Controls.Add(this.tcCadastroFuncionario);
            this.Name = "frmCadastroFuncionario";
            this.Text = "Cadastro de Funcionário";
            this.tcCadastroFuncionario.ResumeLayout(false);
            this.tpDadosPessoais.ResumeLayout(false);
            this.tpDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tcCadastroFuncionario;
        private MetroFramework.Controls.MetroTabPage tpDadosPessoais;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtRG;
        private MetroFramework.Controls.MetroDateTime dtDataNascimento;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtCPF;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSobreNome;
        private MetroFramework.Controls.MetroLabel lbNome;
        private MetroFramework.Controls.MetroTextBox txtNomeFuncionario;
        private MetroFramework.Controls.MetroTabPage tpEndereco;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private System.Windows.Forms.PictureBox imgFoto;
        private MetroFramework.Controls.MetroButton btnLocalizarImg;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox cbEstadoCivil;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtNomeMae;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtNomePai;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtTelefone;
    }
}
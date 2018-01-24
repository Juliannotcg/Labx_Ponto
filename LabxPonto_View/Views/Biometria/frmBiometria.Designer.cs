namespace LabxPonto_View.Views.Biometria
{
    partial class frmBiometria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBiometria));
            this.imgDigital = new System.Windows.Forms.PictureBox();
            this.txtFuncao = new MetroFramework.Controls.MetroLabel();
            this.txtDepartamento = new MetroFramework.Controls.MetroLabel();
            this.txtEmpresa = new MetroFramework.Controls.MetroLabel();
            this.imgFoto = new System.Windows.Forms.PictureBox();
            this.txtNome = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCPF = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.errorProviderFunc = new System.Windows.Forms.ErrorProvider(this.components);
            this.btVerificarDigital = new MetroFramework.Controls.MetroTile();
            this.btCapturar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDigital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(757, 419);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(650, 419);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(7, 434);
            // 
            // imgDigital
            // 
            this.imgDigital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgDigital.Location = new System.Drawing.Point(604, 108);
            this.imgDigital.Name = "imgDigital";
            this.imgDigital.Size = new System.Drawing.Size(169, 179);
            this.imgDigital.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDigital.TabIndex = 77;
            this.imgDigital.TabStop = false;
            this.imgDigital.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.imgDigital_LoadCompleted);
            // 
            // txtFuncao
            // 
            this.txtFuncao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFuncao.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.txtFuncao.Location = new System.Drawing.Point(247, 262);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(309, 25);
            this.txtFuncao.TabIndex = 87;
            this.txtFuncao.UseCustomBackColor = true;
            this.txtFuncao.UseCustomForeColor = true;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartamento.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.txtDepartamento.Location = new System.Drawing.Point(292, 224);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(264, 25);
            this.txtDepartamento.TabIndex = 86;
            this.txtDepartamento.UseCustomBackColor = true;
            this.txtDepartamento.UseCustomForeColor = true;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpresa.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.txtEmpresa.Location = new System.Drawing.Point(256, 189);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(300, 25);
            this.txtEmpresa.TabIndex = 85;
            this.txtEmpresa.UseCustomBackColor = true;
            this.txtEmpresa.UseCustomForeColor = true;
            // 
            // imgFoto
            // 
            this.imgFoto.Image = global::LabxPonto_View.Properties.Resources.photo_1103596_960_720;
            this.imgFoto.Location = new System.Drawing.Point(22, 150);
            this.imgFoto.Margin = new System.Windows.Forms.Padding(2);
            this.imgFoto.Name = "imgFoto";
            this.imgFoto.Size = new System.Drawing.Size(142, 137);
            this.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFoto.TabIndex = 84;
            this.imgFoto.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.txtNome.Location = new System.Drawing.Point(238, 150);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(318, 25);
            this.txtNome.TabIndex = 83;
            this.txtNome.UseCustomBackColor = true;
            this.txtNome.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(170, 262);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(54, 19);
            this.metroLabel5.TabIndex = 82;
            this.metroLabel5.Text = "Função:";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(170, 224);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(91, 19);
            this.metroLabel4.TabIndex = 81;
            this.metroLabel4.Text = "Departameto:";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(169, 189);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 80;
            this.metroLabel3.Text = "Empresa:";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(169, 150);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 79;
            this.metroLabel2.Text = "Nome:";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // txtCPF
            // 
            // 
            // 
            // 
            this.txtCPF.CustomButton.Image = global::LabxPonto_View.Properties.Resources.if_icons_search_1564527;
            this.txtCPF.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.txtCPF.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtCPF.CustomButton.Name = "";
            this.txtCPF.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCPF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCPF.CustomButton.TabIndex = 1;
            this.txtCPF.CustomButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txtCPF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCPF.CustomButton.UseSelectable = true;
            this.txtCPF.CustomButton.UseVisualStyleBackColor = false;
            this.txtCPF.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCPF.Lines = new string[0];
            this.txtCPF.Location = new System.Drawing.Point(23, 92);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(2);
            this.txtCPF.MaxLength = 32767;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.PasswordChar = '\0';
            this.txtCPF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCPF.SelectedText = "";
            this.txtCPF.SelectionLength = 0;
            this.txtCPF.SelectionStart = 0;
            this.txtCPF.ShortcutsEnabled = true;
            this.txtCPF.ShowButton = true;
            this.txtCPF.Size = new System.Drawing.Size(230, 29);
            this.txtCPF.TabIndex = 88;
            this.txtCPF.UseSelectable = true;
            this.txtCPF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCPF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Location = new System.Drawing.Point(23, 71);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(33, 19);
            this.metroLabel26.TabIndex = 89;
            this.metroLabel26.Text = "CPF";
            this.metroLabel26.UseCustomBackColor = true;
            this.metroLabel26.UseCustomForeColor = true;
            // 
            // errorProviderFunc
            // 
            this.errorProviderFunc.ContainerControl = this;
            this.errorProviderFunc.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderFunc.Icon")));
            // 
            // btVerificarDigital
            // 
            this.btVerificarDigital.ActiveControl = null;
            this.btVerificarDigital.Enabled = false;
            this.btVerificarDigital.Location = new System.Drawing.Point(604, 293);
            this.btVerificarDigital.Margin = new System.Windows.Forms.Padding(0);
            this.btVerificarDigital.Name = "btVerificarDigital";
            this.btVerificarDigital.Size = new System.Drawing.Size(169, 40);
            this.btVerificarDigital.TabIndex = 90;
            this.btVerificarDigital.Text = "Verificar";
            this.btVerificarDigital.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btVerificarDigital.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btVerificarDigital.UseSelectable = true;
            this.btVerificarDigital.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // btCapturar
            // 
            this.btCapturar.Location = new System.Drawing.Point(778, 108);
            this.btCapturar.Margin = new System.Windows.Forms.Padding(2);
            this.btCapturar.Name = "btCapturar";
            this.btCapturar.Size = new System.Drawing.Size(73, 60);
            this.btCapturar.TabIndex = 91;
            this.btCapturar.Text = "Capturar";
            this.btCapturar.UseSelectable = true;
            this.btCapturar.Click += new System.EventHandler(this.btCapturar_Click);
            // 
            // frmBiometria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 473);
            this.Controls.Add(this.btCapturar);
            this.Controls.Add(this.btVerificarDigital);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.metroLabel26);
            this.Controls.Add(this.txtFuncao);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.imgFoto);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.imgDigital);
            this.Name = "frmBiometria";
            this.Text = "Biometria";
            this.Controls.SetChildIndex(this.pbLogo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.imgDigital, 0);
            this.Controls.SetChildIndex(this.metroLabel2, 0);
            this.Controls.SetChildIndex(this.metroLabel3, 0);
            this.Controls.SetChildIndex(this.metroLabel4, 0);
            this.Controls.SetChildIndex(this.metroLabel5, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.imgFoto, 0);
            this.Controls.SetChildIndex(this.txtEmpresa, 0);
            this.Controls.SetChildIndex(this.txtDepartamento, 0);
            this.Controls.SetChildIndex(this.txtFuncao, 0);
            this.Controls.SetChildIndex(this.metroLabel26, 0);
            this.Controls.SetChildIndex(this.txtCPF, 0);
            this.Controls.SetChildIndex(this.btVerificarDigital, 0);
            this.Controls.SetChildIndex(this.btCapturar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDigital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgDigital;
        private MetroFramework.Controls.MetroLabel txtFuncao;
        private MetroFramework.Controls.MetroLabel txtDepartamento;
        private MetroFramework.Controls.MetroLabel txtEmpresa;
        private System.Windows.Forms.PictureBox imgFoto;
        private MetroFramework.Controls.MetroLabel txtNome;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtCPF;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private System.Windows.Forms.ErrorProvider errorProviderFunc;
        private MetroFramework.Controls.MetroTile btVerificarDigital;
        private MetroFramework.Controls.MetroButton btCapturar;
    }
}
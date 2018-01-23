namespace LabxPonto_View.Views.Usuário
{
    partial class frmUsuarioCadastro
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
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.lbSenha = new MetroFramework.Controls.MetroLabel();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.lbConfirmarSenha = new MetroFramework.Controls.MetroLabel();
            this.txtConfirmaSenha = new MetroFramework.Controls.MetroTextBox();
            this.lbPerfil = new MetroFramework.Controls.MetroLabel();
            this.cbPerfil = new MetroFramework.Controls.MetroComboBox();
            this.errorProviderUsu = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbUsuario = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(633, 347);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(491, 347);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(9, 370);
            // 
            // metroLink1
            // 
            // 
            // txtUsuario
            // 
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(341, 2);
            this.txtUsuario.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(29, 134);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(375, 36);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(29, 183);
            this.lbSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(47, 20);
            this.lbSenha.TabIndex = 67;
            this.lbSenha.Text = "Senha";
            this.lbSenha.UseCustomBackColor = true;
            // 
            // txtSenha
            // 
            // 
            // 
            // 
            this.txtSenha.CustomButton.Image = null;
            this.txtSenha.CustomButton.Location = new System.Drawing.Point(341, 2);
            this.txtSenha.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenha.CustomButton.Name = "";
            this.txtSenha.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSenha.CustomButton.TabIndex = 1;
            this.txtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenha.CustomButton.UseSelectable = true;
            this.txtSenha.CustomButton.Visible = false;
            this.txtSenha.Lines = new string[0];
            this.txtSenha.Location = new System.Drawing.Point(29, 209);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenha.MaxLength = 10;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.ShortcutsEnabled = true;
            this.txtSenha.Size = new System.Drawing.Size(375, 36);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSelectable = true;
            this.txtSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbConfirmarSenha
            // 
            this.lbConfirmarSenha.AutoSize = true;
            this.lbConfirmarSenha.Location = new System.Drawing.Point(29, 263);
            this.lbConfirmarSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConfirmarSenha.Name = "lbConfirmarSenha";
            this.lbConfirmarSenha.Size = new System.Drawing.Size(106, 20);
            this.lbConfirmarSenha.TabIndex = 69;
            this.lbConfirmarSenha.Text = "Confirma senha";
            this.lbConfirmarSenha.UseCustomBackColor = true;
            // 
            // txtConfirmaSenha
            // 
            // 
            // 
            // 
            this.txtConfirmaSenha.CustomButton.Image = null;
            this.txtConfirmaSenha.CustomButton.Location = new System.Drawing.Point(341, 2);
            this.txtConfirmaSenha.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmaSenha.CustomButton.Name = "";
            this.txtConfirmaSenha.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtConfirmaSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConfirmaSenha.CustomButton.TabIndex = 1;
            this.txtConfirmaSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConfirmaSenha.CustomButton.UseSelectable = true;
            this.txtConfirmaSenha.CustomButton.Visible = false;
            this.txtConfirmaSenha.Lines = new string[0];
            this.txtConfirmaSenha.Location = new System.Drawing.Point(29, 289);
            this.txtConfirmaSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmaSenha.MaxLength = 10;
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.PasswordChar = '*';
            this.txtConfirmaSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmaSenha.SelectedText = "";
            this.txtConfirmaSenha.SelectionLength = 0;
            this.txtConfirmaSenha.SelectionStart = 0;
            this.txtConfirmaSenha.ShortcutsEnabled = true;
            this.txtConfirmaSenha.Size = new System.Drawing.Size(375, 36);
            this.txtConfirmaSenha.TabIndex = 2;
            this.txtConfirmaSenha.UseSelectable = true;
            this.txtConfirmaSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConfirmaSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbPerfil
            // 
            this.lbPerfil.AutoSize = true;
            this.lbPerfil.Location = new System.Drawing.Point(443, 108);
            this.lbPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPerfil.Name = "lbPerfil";
            this.lbPerfil.Size = new System.Drawing.Size(39, 20);
            this.lbPerfil.TabIndex = 70;
            this.lbPerfil.Text = "Perfil";
            this.lbPerfil.UseCustomBackColor = true;
            // 
            // cbPerfil
            // 
            this.cbPerfil.FormattingEnabled = true;
            this.cbPerfil.ItemHeight = 24;
            this.cbPerfil.Items.AddRange(new object[] {
            "",
            "Usuário padrão",
            "Funcionário",
            "Suporte"});
            this.cbPerfil.Location = new System.Drawing.Point(443, 134);
            this.cbPerfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPerfil.Name = "cbPerfil";
            this.cbPerfil.Size = new System.Drawing.Size(328, 30);
            this.cbPerfil.TabIndex = 3;
            this.cbPerfil.UseSelectable = true;
            // 
            // errorProviderUsu
            // 
            this.errorProviderUsu.ContainerControl = this;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(29, 108);
            this.lbUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(56, 20);
            this.lbUsuario.TabIndex = 71;
            this.lbUsuario.Text = "Usuário";
            this.lbUsuario.UseCustomBackColor = true;
            // 
            // frmUsuarioCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 414);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbPerfil);
            this.Controls.Add(this.lbConfirmarSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.cbPerfil);
            this.Controls.Add(this.txtConfirmaSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUsuarioCadastro";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "Usuário";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.frmUsuarioCadastro_Load);
            this.Controls.SetChildIndex(this.pbLogo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.txtUsuario, 0);
            this.Controls.SetChildIndex(this.txtSenha, 0);
            this.Controls.SetChildIndex(this.txtConfirmaSenha, 0);
            this.Controls.SetChildIndex(this.cbPerfil, 0);
            this.Controls.SetChildIndex(this.lbSenha, 0);
            this.Controls.SetChildIndex(this.lbConfirmarSenha, 0);
            this.Controls.SetChildIndex(this.lbPerfil, 0);
            this.Controls.SetChildIndex(this.lbUsuario, 0);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroTextBox txtConfirmaSenha;
        private MetroFramework.Controls.MetroComboBox cbPerfil;
        private System.Windows.Forms.ErrorProvider errorProviderUsu;
        public MetroFramework.Controls.MetroLabel lbSenha;
        public MetroFramework.Controls.MetroLabel lbConfirmarSenha;
        public MetroFramework.Controls.MetroLabel lbUsuario;
        public MetroFramework.Controls.MetroLabel lbPerfil;
    }
}
namespace LabxPonto_View.ConfiguracaoServidor
{
    partial class frmConfiguracaoInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracaoInicial));
            this.txtNomeServidor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtNomeBancoDeDados = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtUsuarioBanco = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtSenhaBanco = new MetroFramework.Controls.MetroTextBox();
            this.errorProviderConfig = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(421, 254);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(275, 254);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNomeServidor
            // 
            // 
            // 
            // 
            this.txtNomeServidor.CustomButton.Image = null;
            this.txtNomeServidor.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.txtNomeServidor.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeServidor.CustomButton.Name = "";
            this.txtNomeServidor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomeServidor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeServidor.CustomButton.TabIndex = 1;
            this.txtNomeServidor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeServidor.CustomButton.UseSelectable = true;
            this.txtNomeServidor.CustomButton.Visible = false;
            this.txtNomeServidor.Lines = new string[0];
            this.txtNomeServidor.Location = new System.Drawing.Point(23, 110);
            this.txtNomeServidor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeServidor.MaxLength = 32767;
            this.txtNomeServidor.Name = "txtNomeServidor";
            this.txtNomeServidor.PasswordChar = '\0';
            this.txtNomeServidor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeServidor.SelectedText = "";
            this.txtNomeServidor.SelectionLength = 0;
            this.txtNomeServidor.SelectionStart = 0;
            this.txtNomeServidor.ShortcutsEnabled = true;
            this.txtNomeServidor.Size = new System.Drawing.Size(227, 23);
            this.txtNomeServidor.TabIndex = 0;
            this.txtNomeServidor.UseSelectable = true;
            this.txtNomeServidor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeServidor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Servidor";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(317, 86);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(108, 20);
            this.metroLabel2.TabIndex = 56;
            this.metroLabel2.Text = "Banco de dados";
            // 
            // txtNomeBancoDeDados
            // 
            // 
            // 
            // 
            this.txtNomeBancoDeDados.CustomButton.Image = null;
            this.txtNomeBancoDeDados.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.txtNomeBancoDeDados.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeBancoDeDados.CustomButton.Name = "";
            this.txtNomeBancoDeDados.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomeBancoDeDados.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeBancoDeDados.CustomButton.TabIndex = 1;
            this.txtNomeBancoDeDados.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeBancoDeDados.CustomButton.UseSelectable = true;
            this.txtNomeBancoDeDados.CustomButton.Visible = false;
            this.txtNomeBancoDeDados.Lines = new string[] {
        "ePonto"};
            this.txtNomeBancoDeDados.Location = new System.Drawing.Point(317, 110);
            this.txtNomeBancoDeDados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeBancoDeDados.MaxLength = 32767;
            this.txtNomeBancoDeDados.Name = "txtNomeBancoDeDados";
            this.txtNomeBancoDeDados.PasswordChar = '\0';
            this.txtNomeBancoDeDados.ReadOnly = true;
            this.txtNomeBancoDeDados.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeBancoDeDados.SelectedText = "";
            this.txtNomeBancoDeDados.SelectionLength = 0;
            this.txtNomeBancoDeDados.SelectionStart = 0;
            this.txtNomeBancoDeDados.ShortcutsEnabled = true;
            this.txtNomeBancoDeDados.Size = new System.Drawing.Size(227, 23);
            this.txtNomeBancoDeDados.TabIndex = 55;
            this.txtNomeBancoDeDados.Text = "ePonto";
            this.txtNomeBancoDeDados.UseSelectable = true;
            this.txtNomeBancoDeDados.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeBancoDeDados.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 159);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 20);
            this.metroLabel3.TabIndex = 58;
            this.metroLabel3.Text = "Usuário";
            // 
            // txtUsuarioBanco
            // 
            // 
            // 
            // 
            this.txtUsuarioBanco.CustomButton.Image = null;
            this.txtUsuarioBanco.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.txtUsuarioBanco.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuarioBanco.CustomButton.Name = "";
            this.txtUsuarioBanco.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsuarioBanco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuarioBanco.CustomButton.TabIndex = 1;
            this.txtUsuarioBanco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuarioBanco.CustomButton.UseSelectable = true;
            this.txtUsuarioBanco.CustomButton.Visible = false;
            this.txtUsuarioBanco.Lines = new string[0];
            this.txtUsuarioBanco.Location = new System.Drawing.Point(23, 182);
            this.txtUsuarioBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuarioBanco.MaxLength = 32767;
            this.txtUsuarioBanco.Name = "txtUsuarioBanco";
            this.txtUsuarioBanco.PasswordChar = '\0';
            this.txtUsuarioBanco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuarioBanco.SelectedText = "";
            this.txtUsuarioBanco.SelectionLength = 0;
            this.txtUsuarioBanco.SelectionStart = 0;
            this.txtUsuarioBanco.ShortcutsEnabled = true;
            this.txtUsuarioBanco.Size = new System.Drawing.Size(227, 23);
            this.txtUsuarioBanco.TabIndex = 57;
            this.txtUsuarioBanco.UseSelectable = true;
            this.txtUsuarioBanco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuarioBanco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(317, 159);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(47, 20);
            this.metroLabel4.TabIndex = 60;
            this.metroLabel4.Text = "Senha";
            // 
            // txtSenhaBanco
            // 
            // 
            // 
            // 
            this.txtSenhaBanco.CustomButton.Image = null;
            this.txtSenhaBanco.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.txtSenhaBanco.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenhaBanco.CustomButton.Name = "";
            this.txtSenhaBanco.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSenhaBanco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSenhaBanco.CustomButton.TabIndex = 1;
            this.txtSenhaBanco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenhaBanco.CustomButton.UseSelectable = true;
            this.txtSenhaBanco.CustomButton.Visible = false;
            this.txtSenhaBanco.Lines = new string[0];
            this.txtSenhaBanco.Location = new System.Drawing.Point(317, 182);
            this.txtSenhaBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenhaBanco.MaxLength = 32767;
            this.txtSenhaBanco.Name = "txtSenhaBanco";
            this.txtSenhaBanco.PasswordChar = '*';
            this.txtSenhaBanco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenhaBanco.SelectedText = "";
            this.txtSenhaBanco.SelectionLength = 0;
            this.txtSenhaBanco.SelectionStart = 0;
            this.txtSenhaBanco.ShortcutsEnabled = true;
            this.txtSenhaBanco.Size = new System.Drawing.Size(227, 23);
            this.txtSenhaBanco.TabIndex = 59;
            this.txtSenhaBanco.UseSelectable = true;
            this.txtSenhaBanco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSenhaBanco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // errorProviderConfig
            // 
            this.errorProviderConfig.ContainerControl = this;
            this.errorProviderConfig.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderConfig.Icon")));
            // 
            // frmConfiguracaoInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 319);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtSenhaBanco);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtUsuarioBanco);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtNomeBancoDeDados);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtNomeServidor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmConfiguracaoInicial";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "Configuração inicial";
            this.Load += new System.EventHandler(this.frmConfiguracaoInicial_Load);
            this.Controls.SetChildIndex(this.txtNomeServidor, 0);
            this.Controls.SetChildIndex(this.metroLabel1, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.txtNomeBancoDeDados, 0);
            this.Controls.SetChildIndex(this.metroLabel2, 0);
            this.Controls.SetChildIndex(this.txtUsuarioBanco, 0);
            this.Controls.SetChildIndex(this.metroLabel3, 0);
            this.Controls.SetChildIndex(this.txtSenhaBanco, 0);
            this.Controls.SetChildIndex(this.metroLabel4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtNomeServidor;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtNomeBancoDeDados;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtUsuarioBanco;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtSenhaBanco;
        private System.Windows.Forms.ErrorProvider errorProviderConfig;
    }
}
namespace LabxPonto_View.Views.Departamentos
{
    partial class frmDepartamentoCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartamentoCadastro));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtDescricaoDepartamento = new MetroFramework.Controls.MetroTextBox();
            this.Função = new MetroFramework.Controls.MetroLabel();
            this.txtNomeDepartamento = new MetroFramework.Controls.MetroTextBox();
            this.errorProviderDep = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDep)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(352, 254);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(244, 254);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvar.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 129);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 62;
            this.metroLabel1.Text = "Descrição";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtDescricaoDepartamento
            // 
            // 
            // 
            // 
            this.txtDescricaoDepartamento.CustomButton.Image = null;
            this.txtDescricaoDepartamento.CustomButton.Location = new System.Drawing.Point(352, 2);
            this.txtDescricaoDepartamento.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricaoDepartamento.CustomButton.Name = "";
            this.txtDescricaoDepartamento.CustomButton.Size = new System.Drawing.Size(65, 65);
            this.txtDescricaoDepartamento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescricaoDepartamento.CustomButton.TabIndex = 1;
            this.txtDescricaoDepartamento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescricaoDepartamento.CustomButton.UseSelectable = true;
            this.txtDescricaoDepartamento.CustomButton.Visible = false;
            this.txtDescricaoDepartamento.Lines = new string[0];
            this.txtDescricaoDepartamento.Location = new System.Drawing.Point(22, 150);
            this.txtDescricaoDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricaoDepartamento.MaxLength = 255;
            this.txtDescricaoDepartamento.Multiline = true;
            this.txtDescricaoDepartamento.Name = "txtDescricaoDepartamento";
            this.txtDescricaoDepartamento.PasswordChar = '\0';
            this.txtDescricaoDepartamento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescricaoDepartamento.SelectedText = "";
            this.txtDescricaoDepartamento.SelectionLength = 0;
            this.txtDescricaoDepartamento.SelectionStart = 0;
            this.txtDescricaoDepartamento.ShortcutsEnabled = true;
            this.txtDescricaoDepartamento.Size = new System.Drawing.Size(420, 70);
            this.txtDescricaoDepartamento.TabIndex = 1;
            this.txtDescricaoDepartamento.UseSelectable = true;
            this.txtDescricaoDepartamento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescricaoDepartamento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Função
            // 
            this.Função.AutoSize = true;
            this.Função.Location = new System.Drawing.Point(22, 77);
            this.Função.Name = "Função";
            this.Função.Size = new System.Drawing.Size(95, 19);
            this.Função.TabIndex = 60;
            this.Função.Text = "Departamento";
            this.Função.UseCustomBackColor = true;
            this.Função.UseCustomForeColor = true;
            // 
            // txtNomeDepartamento
            // 
            // 
            // 
            // 
            this.txtNomeDepartamento.CustomButton.Image = null;
            this.txtNomeDepartamento.CustomButton.Location = new System.Drawing.Point(392, 1);
            this.txtNomeDepartamento.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeDepartamento.CustomButton.Name = "";
            this.txtNomeDepartamento.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNomeDepartamento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeDepartamento.CustomButton.TabIndex = 1;
            this.txtNomeDepartamento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeDepartamento.CustomButton.UseSelectable = true;
            this.txtNomeDepartamento.CustomButton.Visible = false;
            this.txtNomeDepartamento.Lines = new string[0];
            this.txtNomeDepartamento.Location = new System.Drawing.Point(22, 98);
            this.txtNomeDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeDepartamento.MaxLength = 100;
            this.txtNomeDepartamento.Name = "txtNomeDepartamento";
            this.txtNomeDepartamento.PasswordChar = '\0';
            this.txtNomeDepartamento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeDepartamento.SelectedText = "";
            this.txtNomeDepartamento.SelectionLength = 0;
            this.txtNomeDepartamento.SelectionStart = 0;
            this.txtNomeDepartamento.ShortcutsEnabled = true;
            this.txtNomeDepartamento.Size = new System.Drawing.Size(420, 29);
            this.txtNomeDepartamento.TabIndex = 0;
            this.txtNomeDepartamento.UseSelectable = true;
            this.txtNomeDepartamento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeDepartamento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // errorProviderDep
            // 
            this.errorProviderDep.ContainerControl = this;
            this.errorProviderDep.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderDep.Icon")));
            // 
            // frmDepartamentoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 308);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtDescricaoDepartamento);
            this.Controls.Add(this.Função);
            this.Controls.Add(this.txtNomeDepartamento);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDepartamentoCadastro";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Departamento";
            this.Load += new System.EventHandler(this.frmDepartamentoCadastro_Load);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.txtNomeDepartamento, 0);
            this.Controls.SetChildIndex(this.Função, 0);
            this.Controls.SetChildIndex(this.txtDescricaoDepartamento, 0);
            this.Controls.SetChildIndex(this.metroLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel Função;
        private MetroFramework.Controls.MetroTextBox txtNomeDepartamento;
        private System.Windows.Forms.ErrorProvider errorProviderDep;
        public MetroFramework.Controls.MetroTextBox txtDescricaoDepartamento;
    }
}
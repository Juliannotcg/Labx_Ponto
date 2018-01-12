namespace LabxPonto_View.Views.Funções
{
    partial class frmFuncaoCadastro
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
            this.Função = new MetroFramework.Controls.MetroLabel();
            this.txtNomeFuncao = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtDescricaoFuncao = new MetroFramework.Controls.MetroTextBox();
            this.Departamento = new MetroFramework.Controls.MetroLabel();
            this.cbDepartamento = new MetroFramework.Controls.MetroComboBox();
            this.errorProviderFun = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFun)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(464, 356);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(319, 356);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(4, 380);
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(142, 11);
            // 
            // Função
            // 
            this.Função.AutoSize = true;
            this.Função.Location = new System.Drawing.Point(29, 162);
            this.Função.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Função.Name = "Função";
            this.Função.Size = new System.Drawing.Size(54, 20);
            this.Função.TabIndex = 56;
            this.Função.Text = "Função";
            this.Função.UseCustomBackColor = true;
            this.Função.UseCustomForeColor = true;
            // 
            // txtNomeFuncao
            // 
            // 
            // 
            // 
            this.txtNomeFuncao.CustomButton.Image = null;
            this.txtNomeFuncao.CustomButton.Location = new System.Drawing.Point(526, 2);
            this.txtNomeFuncao.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeFuncao.CustomButton.Name = "";
            this.txtNomeFuncao.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtNomeFuncao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeFuncao.CustomButton.TabIndex = 1;
            this.txtNomeFuncao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeFuncao.CustomButton.UseSelectable = true;
            this.txtNomeFuncao.CustomButton.Visible = false;
            this.txtNomeFuncao.Lines = new string[0];
            this.txtNomeFuncao.Location = new System.Drawing.Point(29, 188);
            this.txtNomeFuncao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeFuncao.MaxLength = 32767;
            this.txtNomeFuncao.Name = "txtNomeFuncao";
            this.txtNomeFuncao.PasswordChar = '\0';
            this.txtNomeFuncao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeFuncao.SelectedText = "";
            this.txtNomeFuncao.SelectionLength = 0;
            this.txtNomeFuncao.SelectionStart = 0;
            this.txtNomeFuncao.ShortcutsEnabled = true;
            this.txtNomeFuncao.Size = new System.Drawing.Size(560, 36);
            this.txtNomeFuncao.TabIndex = 2;
            this.txtNomeFuncao.UseSelectable = true;
            this.txtNomeFuncao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeFuncao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 226);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 20);
            this.metroLabel1.TabIndex = 58;
            this.metroLabel1.Text = "Descrição";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtDescricaoFuncao
            // 
            // 
            // 
            // 
            this.txtDescricaoFuncao.CustomButton.Image = null;
            this.txtDescricaoFuncao.CustomButton.Location = new System.Drawing.Point(476, 2);
            this.txtDescricaoFuncao.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricaoFuncao.CustomButton.Name = "";
            this.txtDescricaoFuncao.CustomButton.Size = new System.Drawing.Size(81, 81);
            this.txtDescricaoFuncao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescricaoFuncao.CustomButton.TabIndex = 1;
            this.txtDescricaoFuncao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescricaoFuncao.CustomButton.UseSelectable = true;
            this.txtDescricaoFuncao.CustomButton.Visible = false;
            this.txtDescricaoFuncao.Lines = new string[0];
            this.txtDescricaoFuncao.Location = new System.Drawing.Point(29, 252);
            this.txtDescricaoFuncao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricaoFuncao.MaxLength = 32767;
            this.txtDescricaoFuncao.Name = "txtDescricaoFuncao";
            this.txtDescricaoFuncao.PasswordChar = '\0';
            this.txtDescricaoFuncao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescricaoFuncao.SelectedText = "";
            this.txtDescricaoFuncao.SelectionLength = 0;
            this.txtDescricaoFuncao.SelectionStart = 0;
            this.txtDescricaoFuncao.ShortcutsEnabled = true;
            this.txtDescricaoFuncao.Size = new System.Drawing.Size(560, 86);
            this.txtDescricaoFuncao.TabIndex = 3;
            this.txtDescricaoFuncao.UseSelectable = true;
            this.txtDescricaoFuncao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescricaoFuncao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Departamento
            // 
            this.Departamento.AutoSize = true;
            this.Departamento.Location = new System.Drawing.Point(29, 98);
            this.Departamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Departamento.Name = "Departamento";
            this.Departamento.Size = new System.Drawing.Size(99, 20);
            this.Departamento.TabIndex = 0;
            this.Departamento.Text = "Departamento";
            this.Departamento.UseCustomBackColor = true;
            this.Departamento.UseCustomForeColor = true;
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.ItemHeight = 24;
            this.cbDepartamento.Location = new System.Drawing.Point(29, 124);
            this.cbDepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(328, 30);
            this.cbDepartamento.TabIndex = 1;
            this.cbDepartamento.UseSelectable = true;
            // 
            // errorProviderFun
            // 
            this.errorProviderFun.ContainerControl = this;
            // 
            // frmFuncaoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 422);
            this.Controls.Add(this.Departamento);
            this.Controls.Add(this.cbDepartamento);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtDescricaoFuncao);
            this.Controls.Add(this.Função);
            this.Controls.Add(this.txtNomeFuncao);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmFuncaoCadastro";
            this.Padding = new System.Windows.Forms.Padding(36, 91, 36, 31);
            this.Text = "Função";
            this.Load += new System.EventHandler(this.frmFuncaoCadastro_Load);
            this.Controls.SetChildIndex(this.metroLink1, 0);
            this.Controls.SetChildIndex(this.pbLogo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.txtNomeFuncao, 0);
            this.Controls.SetChildIndex(this.Função, 0);
            this.Controls.SetChildIndex(this.txtDescricaoFuncao, 0);
            this.Controls.SetChildIndex(this.metroLabel1, 0);
            this.Controls.SetChildIndex(this.cbDepartamento, 0);
            this.Controls.SetChildIndex(this.Departamento, 0);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Função;
        private MetroFramework.Controls.MetroTextBox txtNomeFuncao;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtDescricaoFuncao;
        private MetroFramework.Controls.MetroLabel Departamento;
        private MetroFramework.Controls.MetroComboBox cbDepartamento;
        private System.Windows.Forms.ErrorProvider errorProviderFun;
    }
}
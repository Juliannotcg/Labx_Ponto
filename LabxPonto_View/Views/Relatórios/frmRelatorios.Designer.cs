namespace LabxPonto_View.Views
{
    partial class frmRelatorios
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCPF = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel37 = new MetroFramework.Controls.MetroLabel();
            this.cmbEstado = new MetroFramework.Controls.MetroComboBox();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel29 = new MetroFramework.Controls.MetroLabel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(604, 238);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(473, 238);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(7, 261);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(33, 20);
            this.metroLabel1.TabIndex = 56;
            this.metroLabel1.Text = "CPF";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // txtCPF
            // 
            // 
            // 
            // 
            this.txtCPF.CustomButton.Image = null;
            this.txtCPF.CustomButton.Location = new System.Drawing.Point(359, 1);
            this.txtCPF.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCPF.CustomButton.Name = "";
            this.txtCPF.CustomButton.Size = new System.Drawing.Size(55, 50);
            this.txtCPF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCPF.CustomButton.TabIndex = 1;
            this.txtCPF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCPF.CustomButton.UseSelectable = true;
            this.txtCPF.CustomButton.Visible = false;
            this.txtCPF.Lines = new string[0];
            this.txtCPF.Location = new System.Drawing.Point(29, 110);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCPF.MaxLength = 20;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.PasswordChar = '\0';
            this.txtCPF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCPF.SelectedText = "";
            this.txtCPF.SelectionLength = 0;
            this.txtCPF.SelectionStart = 0;
            this.txtCPF.ShortcutsEnabled = true;
            this.txtCPF.Size = new System.Drawing.Size(311, 43);
            this.txtCPF.TabIndex = 55;
            this.txtCPF.UseSelectable = true;
            this.txtCPF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCPF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCPF.Click += new System.EventHandler(this.txtCPF_Click);
            // 
            // metroLabel37
            // 
            this.metroLabel37.AutoSize = true;
            this.metroLabel37.Location = new System.Drawing.Point(367, 86);
            this.metroLabel37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel37.Name = "metroLabel37";
            this.metroLabel37.Size = new System.Drawing.Size(114, 20);
            this.metroLabel37.TabIndex = 63;
            this.metroLabel37.Text = "Tipo do Relatório";
            this.metroLabel37.UseCustomBackColor = true;
            this.metroLabel37.UseCustomForeColor = true;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.ItemHeight = 29;
            this.cmbEstado.Location = new System.Drawing.Point(367, 110);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(365, 35);
            this.cmbEstado.TabIndex = 62;
            this.cmbEstado.UseSelectable = true;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNascimento.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtDataNascimento.Location = new System.Drawing.Point(25, 187);
            this.txtDataNascimento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(171, 34);
            this.txtDataNascimento.TabIndex = 64;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // metroLabel29
            // 
            this.metroLabel29.AutoSize = true;
            this.metroLabel29.Location = new System.Drawing.Point(28, 160);
            this.metroLabel29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel29.Name = "metroLabel29";
            this.metroLabel29.Size = new System.Drawing.Size(56, 20);
            this.metroLabel29.TabIndex = 65;
            this.metroLabel29.Text = "Período";
            this.metroLabel29.UseCustomBackColor = true;
            this.metroLabel29.UseCustomForeColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.maskedTextBox1.Location = new System.Drawing.Point(231, 187);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(171, 34);
            this.maskedTextBox1.TabIndex = 66;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(205, 199);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(16, 20);
            this.metroLabel2.TabIndex = 67;
            this.metroLabel2.Text = "à";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 304);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.metroLabel29);
            this.Controls.Add(this.metroLabel37);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtCPF);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmRelatorios";
            this.Padding = new System.Windows.Forms.Padding(36, 91, 36, 31);
            this.Text = "Relatórios";
            this.Controls.SetChildIndex(this.pbLogo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.txtCPF, 0);
            this.Controls.SetChildIndex(this.metroLabel1, 0);
            this.Controls.SetChildIndex(this.cmbEstado, 0);
            this.Controls.SetChildIndex(this.metroLabel37, 0);
            this.Controls.SetChildIndex(this.metroLabel29, 0);
            this.Controls.SetChildIndex(this.txtDataNascimento, 0);
            this.Controls.SetChildIndex(this.maskedTextBox1, 0);
            this.Controls.SetChildIndex(this.metroLabel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCPF;
        private MetroFramework.Controls.MetroLabel metroLabel37;
        private MetroFramework.Controls.MetroComboBox cmbEstado;
        public System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private MetroFramework.Controls.MetroLabel metroLabel29;
        public System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}
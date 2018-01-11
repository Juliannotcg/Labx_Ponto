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
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(453, 193);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(355, 193);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 68);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(33, 19);
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
            this.txtCPF.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txtCPF.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtCPF.CustomButton.Name = "";
            this.txtCPF.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtCPF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCPF.CustomButton.TabIndex = 1;
            this.txtCPF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCPF.CustomButton.UseSelectable = true;
            this.txtCPF.CustomButton.Visible = false;
            this.txtCPF.Lines = new string[0];
            this.txtCPF.Location = new System.Drawing.Point(22, 89);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(2);
            this.txtCPF.MaxLength = 20;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.PasswordChar = '\0';
            this.txtCPF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCPF.SelectedText = "";
            this.txtCPF.SelectionLength = 0;
            this.txtCPF.SelectionStart = 0;
            this.txtCPF.ShortcutsEnabled = true;
            this.txtCPF.Size = new System.Drawing.Size(233, 35);
            this.txtCPF.TabIndex = 55;
            this.txtCPF.UseSelectable = true;
            this.txtCPF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCPF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCPF.Click += new System.EventHandler(this.txtCPF_Click);
            // 
            // metroLabel37
            // 
            this.metroLabel37.AutoSize = true;
            this.metroLabel37.Location = new System.Drawing.Point(275, 70);
            this.metroLabel37.Name = "metroLabel37";
            this.metroLabel37.Size = new System.Drawing.Size(112, 19);
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
            this.cmbEstado.Location = new System.Drawing.Point(275, 89);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(275, 35);
            this.cmbEstado.TabIndex = 62;
            this.cmbEstado.UseSelectable = true;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNascimento.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtDataNascimento.Location = new System.Drawing.Point(19, 152);
            this.txtDataNascimento.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(129, 29);
            this.txtDataNascimento.TabIndex = 64;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // metroLabel29
            // 
            this.metroLabel29.AutoSize = true;
            this.metroLabel29.Location = new System.Drawing.Point(21, 130);
            this.metroLabel29.Name = "metroLabel29";
            this.metroLabel29.Size = new System.Drawing.Size(55, 19);
            this.metroLabel29.TabIndex = 65;
            this.metroLabel29.Text = "Período";
            this.metroLabel29.UseCustomBackColor = true;
            this.metroLabel29.UseCustomForeColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.maskedTextBox1.Location = new System.Drawing.Point(173, 152);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(129, 29);
            this.maskedTextBox1.TabIndex = 66;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(154, 162);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(16, 19);
            this.metroLabel2.TabIndex = 67;
            this.metroLabel2.Text = "à";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 247);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.metroLabel29);
            this.Controls.Add(this.metroLabel37);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtCPF);
            this.Name = "frmRelatorios";
            this.Text = "Relatórios";
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
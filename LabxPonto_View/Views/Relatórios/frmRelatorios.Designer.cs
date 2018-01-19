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
            this.components = new System.ComponentModel.Container();
            this.metroLabel29 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.errorProviderRlt = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtDataIni = new MetroFramework.Controls.MetroDateTime();
            this.dtDataFim = new MetroFramework.Controls.MetroDateTime();
            this.txtCPF = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRlt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(383, 238);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(252, 238);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(7, 261);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(241, 199);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(16, 20);
            this.metroLabel2.TabIndex = 67;
            this.metroLabel2.Text = "a";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Location = new System.Drawing.Point(27, 84);
            this.metroLabel26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(33, 20);
            this.metroLabel26.TabIndex = 91;
            this.metroLabel26.Text = "CPF";
            this.metroLabel26.UseCustomBackColor = true;
            this.metroLabel26.UseCustomForeColor = true;
            // 
            // errorProviderRlt
            // 
            this.errorProviderRlt.ContainerControl = this;
            // 
            // dtDataIni
            // 
            this.dtDataIni.Location = new System.Drawing.Point(27, 187);
            this.dtDataIni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDataIni.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtDataIni.Name = "dtDataIni";
            this.dtDataIni.Size = new System.Drawing.Size(200, 30);
            this.dtDataIni.TabIndex = 1;
            // 
            // dtDataFim
            // 
            this.dtDataFim.Location = new System.Drawing.Point(280, 187);
            this.dtDataFim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDataFim.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtDataFim.Name = "dtDataFim";
            this.dtDataFim.Size = new System.Drawing.Size(200, 30);
            this.dtDataFim.TabIndex = 2;
            // 
            // txtCPF
            // 
            // 
            // 
            // 
            this.txtCPF.CustomButton.Image = null;
            this.txtCPF.CustomButton.Location = new System.Drawing.Point(229, 2);
            this.txtCPF.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCPF.CustomButton.Name = "";
            this.txtCPF.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtCPF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCPF.CustomButton.TabIndex = 1;
            this.txtCPF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCPF.CustomButton.UseSelectable = true;
            this.txtCPF.CustomButton.Visible = false;
            this.txtCPF.Lines = new string[0];
            this.txtCPF.Location = new System.Drawing.Point(28, 106);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.PasswordChar = '\0';
            this.txtCPF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCPF.SelectedText = "";
            this.txtCPF.SelectionLength = 0;
            this.txtCPF.SelectionStart = 0;
            this.txtCPF.ShortcutsEnabled = true;
            this.txtCPF.Size = new System.Drawing.Size(263, 36);
            this.txtCPF.TabIndex = 0;
            this.txtCPF.UseSelectable = true;
            this.txtCPF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCPF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave_1);
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 304);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.dtDataFim);
            this.Controls.Add(this.dtDataIni);
            this.Controls.Add(this.metroLabel26);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel29);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmRelatorios";
            this.Padding = new System.Windows.Forms.Padding(36, 91, 36, 31);
            this.Text = "Relatórios";
            this.Controls.SetChildIndex(this.metroLink1, 0);
            this.Controls.SetChildIndex(this.pbLogo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.metroLabel29, 0);
            this.Controls.SetChildIndex(this.metroLabel2, 0);
            this.Controls.SetChildIndex(this.metroLabel26, 0);
            this.Controls.SetChildIndex(this.dtDataIni, 0);
            this.Controls.SetChildIndex(this.dtDataFim, 0);
            this.Controls.SetChildIndex(this.txtCPF, 0);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRlt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel29;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private System.Windows.Forms.ErrorProvider errorProviderRlt;
        private MetroFramework.Controls.MetroDateTime dtDataFim;
        private MetroFramework.Controls.MetroDateTime dtDataIni;
        private MetroFramework.Controls.MetroTextBox txtCPF;
    }
}
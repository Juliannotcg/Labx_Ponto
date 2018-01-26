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
            this.gbPonto = new System.Windows.Forms.GroupBox();
            this.gbFuncionarioEmpresa = new System.Windows.Forms.GroupBox();
            this.txtCNPJ = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbFuncionarioEmpresa = new MetroFramework.Controls.MetroRadioButton();
            this.rbPonto = new MetroFramework.Controls.MetroRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRlt)).BeginInit();
            this.gbPonto.SuspendLayout();
            this.gbFuncionarioEmpresa.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(420, 362);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(289, 362);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(7, 385);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // metroLabel29
            // 
            this.metroLabel29.AutoSize = true;
            this.metroLabel29.Location = new System.Drawing.Point(14, 102);
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
            this.metroLabel2.Location = new System.Drawing.Point(227, 141);
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
            this.metroLabel26.Location = new System.Drawing.Point(13, 31);
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
            this.dtDataIni.Location = new System.Drawing.Point(13, 129);
            this.dtDataIni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDataIni.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtDataIni.Name = "dtDataIni";
            this.dtDataIni.Size = new System.Drawing.Size(200, 30);
            this.dtDataIni.TabIndex = 1;
            // 
            // dtDataFim
            // 
            this.dtDataFim.Location = new System.Drawing.Point(260, 129);
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
            this.txtCPF.Location = new System.Drawing.Point(14, 58);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCPF.MaxLength = 14;
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
            // gbPonto
            // 
            this.gbPonto.Controls.Add(this.dtDataIni);
            this.gbPonto.Controls.Add(this.gbFuncionarioEmpresa);
            this.gbPonto.Controls.Add(this.txtCPF);
            this.gbPonto.Controls.Add(this.metroLabel29);
            this.gbPonto.Controls.Add(this.dtDataFim);
            this.gbPonto.Controls.Add(this.metroLabel2);
            this.gbPonto.Controls.Add(this.metroLabel26);
            this.gbPonto.Location = new System.Drawing.Point(20, 165);
            this.gbPonto.Name = "gbPonto";
            this.gbPonto.Size = new System.Drawing.Size(485, 188);
            this.gbPonto.TabIndex = 92;
            this.gbPonto.TabStop = false;
            this.gbPonto.Text = "Ponto Funcionário";
            // 
            // gbFuncionarioEmpresa
            // 
            this.gbFuncionarioEmpresa.Controls.Add(this.txtCNPJ);
            this.gbFuncionarioEmpresa.Controls.Add(this.metroLabel4);
            this.gbFuncionarioEmpresa.Location = new System.Drawing.Point(0, 0);
            this.gbFuncionarioEmpresa.Name = "gbFuncionarioEmpresa";
            this.gbFuncionarioEmpresa.Size = new System.Drawing.Size(485, 112);
            this.gbFuncionarioEmpresa.TabIndex = 93;
            this.gbFuncionarioEmpresa.TabStop = false;
            this.gbFuncionarioEmpresa.Text = "Funcionário por empresa";
            this.gbFuncionarioEmpresa.Visible = false;
            // 
            // txtCNPJ
            // 
            // 
            // 
            // 
            this.txtCNPJ.CustomButton.Image = null;
            this.txtCNPJ.CustomButton.Location = new System.Drawing.Point(229, 2);
            this.txtCNPJ.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCNPJ.CustomButton.Name = "";
            this.txtCNPJ.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtCNPJ.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCNPJ.CustomButton.TabIndex = 1;
            this.txtCNPJ.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCNPJ.CustomButton.UseSelectable = true;
            this.txtCNPJ.CustomButton.Visible = false;
            this.txtCNPJ.Lines = new string[0];
            this.txtCNPJ.Location = new System.Drawing.Point(14, 58);
            this.txtCNPJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCNPJ.MaxLength = 18;
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.PasswordChar = '\0';
            this.txtCNPJ.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCNPJ.SelectedText = "";
            this.txtCNPJ.SelectionLength = 0;
            this.txtCNPJ.SelectionStart = 0;
            this.txtCNPJ.ShortcutsEnabled = true;
            this.txtCNPJ.Size = new System.Drawing.Size(263, 36);
            this.txtCNPJ.TabIndex = 0;
            this.txtCNPJ.UseSelectable = true;
            this.txtCNPJ.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCNPJ.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(13, 31);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(41, 20);
            this.metroLabel4.TabIndex = 91;
            this.metroLabel4.Text = "CNPJ";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbFuncionarioEmpresa);
            this.groupBox3.Controls.Add(this.rbPonto);
            this.groupBox3.Location = new System.Drawing.Point(20, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 74);
            this.groupBox3.TabIndex = 94;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Relatório";
            // 
            // rbFuncionarioEmpresa
            // 
            this.rbFuncionarioEmpresa.AutoSize = true;
            this.rbFuncionarioEmpresa.Location = new System.Drawing.Point(174, 34);
            this.rbFuncionarioEmpresa.Name = "rbFuncionarioEmpresa";
            this.rbFuncionarioEmpresa.Size = new System.Drawing.Size(171, 17);
            this.rbFuncionarioEmpresa.TabIndex = 1;
            this.rbFuncionarioEmpresa.Text = "Funcionário por empresa";
            this.rbFuncionarioEmpresa.UseSelectable = true;
            this.rbFuncionarioEmpresa.CheckedChanged += new System.EventHandler(this.rbFuncionarioEmpresa_CheckedChanged);
            // 
            // rbPonto
            // 
            this.rbPonto.AutoSize = true;
            this.rbPonto.Location = new System.Drawing.Point(19, 34);
            this.rbPonto.Name = "rbPonto";
            this.rbPonto.Size = new System.Drawing.Size(135, 17);
            this.rbPonto.TabIndex = 0;
            this.rbPonto.Text = "Relatório de ponto";
            this.rbPonto.UseSelectable = true;
            this.rbPonto.CheckedChanged += new System.EventHandler(this.rbPonto_CheckedChanged);
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 428);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbPonto);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmRelatorios";
            this.Padding = new System.Windows.Forms.Padding(36, 91, 36, 31);
            this.Text = "Relatórios";
            this.Controls.SetChildIndex(this.pbLogo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.gbPonto, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRlt)).EndInit();
            this.gbPonto.ResumeLayout(false);
            this.gbPonto.PerformLayout();
            this.gbFuncionarioEmpresa.ResumeLayout(false);
            this.gbFuncionarioEmpresa.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel29;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private System.Windows.Forms.ErrorProvider errorProviderRlt;
        private MetroFramework.Controls.MetroDateTime dtDataFim;
        private MetroFramework.Controls.MetroDateTime dtDataIni;
        private MetroFramework.Controls.MetroTextBox txtCPF;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroRadioButton rbFuncionarioEmpresa;
        private MetroFramework.Controls.MetroRadioButton rbPonto;
        private System.Windows.Forms.GroupBox gbFuncionarioEmpresa;
        private MetroFramework.Controls.MetroTextBox txtCNPJ;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox gbPonto;
    }
}
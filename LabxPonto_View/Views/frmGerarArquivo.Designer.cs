namespace LabxPonto_View.Views
{
    partial class frmGerarArquivo
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
            this.dtDataIni = new MetroFramework.Controls.MetroDateTime();
            this.dtDataFim = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnConfirmar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.progresseGerarArquivo = new MetroFramework.Controls.MetroProgressBar();
            this.SuspendLayout();
            // 
            // dtDataIni
            // 
            this.dtDataIni.Location = new System.Drawing.Point(23, 111);
            this.dtDataIni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDataIni.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtDataIni.Name = "dtDataIni";
            this.dtDataIni.Size = new System.Drawing.Size(200, 30);
            this.dtDataIni.TabIndex = 0;
            // 
            // dtDataFim
            // 
            this.dtDataFim.Location = new System.Drawing.Point(275, 111);
            this.dtDataFim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDataFim.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtDataFim.Name = "dtDataFim";
            this.dtDataFim.Size = new System.Drawing.Size(200, 30);
            this.dtDataFim.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Período";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(241, 121);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(16, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "à";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(24, 166);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(121, 39);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseSelectable = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(151, 166);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 39);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // progresseGerarArquivo
            // 
            this.progresseGerarArquivo.Location = new System.Drawing.Point(23, 210);
            this.progresseGerarArquivo.Name = "progresseGerarArquivo";
            this.progresseGerarArquivo.Size = new System.Drawing.Size(452, 23);
            this.progresseGerarArquivo.TabIndex = 6;
            // 
            // frmGerarArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 237);
            this.Controls.Add(this.progresseGerarArquivo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtDataFim);
            this.Controls.Add(this.dtDataIni);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGerarArquivo";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "Gerar Arquivo de Ponto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime dtDataIni;
        private MetroFramework.Controls.MetroDateTime dtDataFim;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnConfirmar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroProgressBar progresseGerarArquivo;
    }
}
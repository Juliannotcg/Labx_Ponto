namespace LabxPonto_View.Views.Cam
{
    partial class frmWebCam
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
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.picWebCam = new System.Windows.Forms.PictureBox();
            this.btCapturar = new MetroFramework.Controls.MetroButton();
            this.btSalvarImagem = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWebCam)).BeginInit();
            this.SuspendLayout();
            // 
            // picImagem
            // 
            this.picImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImagem.Location = new System.Drawing.Point(630, 64);
            this.picImagem.Margin = new System.Windows.Forms.Padding(4);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(581, 400);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 2;
            this.picImagem.TabStop = false;
            // 
            // picWebCam
            // 
            this.picWebCam.BackColor = System.Drawing.Color.White;
            this.picWebCam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picWebCam.Location = new System.Drawing.Point(24, 64);
            this.picWebCam.Margin = new System.Windows.Forms.Padding(4);
            this.picWebCam.Name = "picWebCam";
            this.picWebCam.Size = new System.Drawing.Size(581, 400);
            this.picWebCam.TabIndex = 1;
            this.picWebCam.TabStop = false;
            // 
            // btCapturar
            // 
            this.btCapturar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btCapturar.Location = new System.Drawing.Point(24, 479);
            this.btCapturar.Margin = new System.Windows.Forms.Padding(2);
            this.btCapturar.Name = "btCapturar";
            this.btCapturar.Size = new System.Drawing.Size(581, 48);
            this.btCapturar.TabIndex = 15;
            this.btCapturar.Text = "Capturar";
            this.btCapturar.UseSelectable = true;
            this.btCapturar.Click += new System.EventHandler(this.btCapturar_Click);
            // 
            // btSalvarImagem
            // 
            this.btSalvarImagem.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btSalvarImagem.Location = new System.Drawing.Point(630, 479);
            this.btSalvarImagem.Margin = new System.Windows.Forms.Padding(2);
            this.btSalvarImagem.Name = "btSalvarImagem";
            this.btSalvarImagem.Size = new System.Drawing.Size(581, 48);
            this.btSalvarImagem.TabIndex = 16;
            this.btSalvarImagem.Text = "Salvar";
            this.btSalvarImagem.UseSelectable = true;
            this.btSalvarImagem.Click += new System.EventHandler(this.btSalvarImagem_Click);
            // 
            // frmWebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 549);
            this.Controls.Add(this.btSalvarImagem);
            this.Controls.Add(this.btCapturar);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.picWebCam);
            this.Name = "frmWebCam";
            this.Text = "Capturar Imagem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmWebCam_FormClosed);
            this.Load += new System.EventHandler(this.frmWebCam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWebCam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picWebCam;
        private System.Windows.Forms.PictureBox picImagem;
        private MetroFramework.Controls.MetroButton btCapturar;
        private MetroFramework.Controls.MetroButton btSalvarImagem;
    }
}
﻿namespace LabxPonto_View.Views
{
    partial class frmMain
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.mtCadastro = new MetroFramework.Controls.MetroTile();
            this.mtConfiguracoes = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::LabxPonto_View.Properties.Resources.LogoEmpresa;
            this.pbLogo.Location = new System.Drawing.Point(23, 16);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(496, 174);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // mtCadastro
            // 
            this.mtCadastro.ActiveControl = null;
            this.mtCadastro.Location = new System.Drawing.Point(279, 196);
            this.mtCadastro.Name = "mtCadastro";
            this.mtCadastro.Size = new System.Drawing.Size(240, 151);
            this.mtCadastro.TabIndex = 1;
            this.mtCadastro.Text = "Cadastros";
            this.mtCadastro.UseSelectable = true;
            this.mtCadastro.Click += new System.EventHandler(this.mtCadastro_Click);
            // 
            // mtConfiguracoes
            // 
            this.mtConfiguracoes.ActiveControl = null;
            this.mtConfiguracoes.Location = new System.Drawing.Point(23, 196);
            this.mtConfiguracoes.Name = "mtConfiguracoes";
            this.mtConfiguracoes.Size = new System.Drawing.Size(250, 151);
            this.mtConfiguracoes.TabIndex = 2;
            this.mtConfiguracoes.Text = "Configurações";
            this.mtConfiguracoes.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(23, 353);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(496, 97);
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "Relatórios";
            this.metroTile1.UseSelectable = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 492);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mtConfiguracoes);
            this.Controls.Add(this.mtCadastro);
            this.Controls.Add(this.pbLogo);
            this.Name = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private MetroFramework.Controls.MetroTile mtCadastro;
        private MetroFramework.Controls.MetroTile mtConfiguracoes;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}
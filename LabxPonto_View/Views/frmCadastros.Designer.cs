﻿namespace LabxPonto_View.Views
{
    partial class frmCadastros
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.btnCadastroDep = new MetroFramework.Controls.MetroTile();
            this.btnCadastroFunc = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(5, 82);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(344, 140);
            this.metroTile1.TabIndex = 4;
            this.metroTile1.Text = "Funcionário";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(353, 152);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(175, 142);
            this.metroTile2.TabIndex = 5;
            this.metroTile2.Text = "Empresa";
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // btnCadastroDep
            // 
            this.btnCadastroDep.ActiveControl = null;
            this.btnCadastroDep.Location = new System.Drawing.Point(5, 226);
            this.btnCadastroDep.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastroDep.Name = "btnCadastroDep";
            this.btnCadastroDep.Size = new System.Drawing.Size(344, 68);
            this.btnCadastroDep.TabIndex = 6;
            this.btnCadastroDep.Text = "Departamento";
            this.btnCadastroDep.UseSelectable = true;
            this.btnCadastroDep.Click += new System.EventHandler(this.btnCadastroDep_Click);
            // 
            // btnCadastroFunc
            // 
            this.btnCadastroFunc.ActiveControl = null;
            this.btnCadastroFunc.Location = new System.Drawing.Point(353, 82);
            this.btnCadastroFunc.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastroFunc.Name = "btnCadastroFunc";
            this.btnCadastroFunc.Size = new System.Drawing.Size(175, 68);
            this.btnCadastroFunc.TabIndex = 7;
            this.btnCadastroFunc.Text = "Funções";
            this.btnCadastroFunc.UseSelectable = true;
            this.btnCadastroFunc.Click += new System.EventHandler(this.btnCadastroFunc_Click);
            // 
            // frmCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 310);
            this.Controls.Add(this.btnCadastroFunc);
            this.Controls.Add(this.btnCadastroDep);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Name = "frmCadastros";
            this.Text = "Cadastro";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile btnCadastroDep;
        private MetroFramework.Controls.MetroTile btnCadastroFunc;
    }
}
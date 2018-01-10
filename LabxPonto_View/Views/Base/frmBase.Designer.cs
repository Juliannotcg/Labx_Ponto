﻿namespace LabxPonto_View.Views.Base
{
    partial class frmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase));
            this.btnVisualizar = new MetroFramework.Controls.MetroTile();
            this.btExcluir = new MetroFramework.Controls.MetroTile();
            this.btAlterar = new MetroFramework.Controls.MetroTile();
            this.btNovo = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.ActiveControl = null;
            this.btnVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnVisualizar.Location = new System.Drawing.Point(23, 291);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(156, 37);
            this.btnVisualizar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnVisualizar.TabIndex = 59;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseCustomBackColor = true;
            this.btnVisualizar.UseSelectable = true;
            this.btnVisualizar.UseTileImage = true;
            // 
            // btExcluir
            // 
            this.btExcluir.ActiveControl = null;
            this.btExcluir.Location = new System.Drawing.Point(104, 196);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 89);
            this.btExcluir.Style = MetroFramework.MetroColorStyle.Red;
            this.btExcluir.TabIndex = 58;
            this.btExcluir.Text = "Deletar";
            this.btExcluir.UseSelectable = true;
            this.btExcluir.UseTileImage = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.ActiveControl = null;
            this.btAlterar.Location = new System.Drawing.Point(23, 196);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 89);
            this.btAlterar.Style = MetroFramework.MetroColorStyle.Silver;
            this.btAlterar.TabIndex = 57;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseSelectable = true;
            this.btAlterar.UseTileImage = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btNovo
            // 
            this.btNovo.ActiveControl = null;
            this.btNovo.Location = new System.Drawing.Point(23, 107);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(156, 82);
            this.btNovo.Style = MetroFramework.MetroColorStyle.Blue;
            this.btNovo.TabIndex = 56;
            this.btNovo.Text = "Novo";
            this.btNovo.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btNovo.UseSelectable = true;
            this.btNovo.UseTileImage = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 351);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btNovo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBase";
            this.Text = "Base";
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroTile btNovo;
        public MetroFramework.Controls.MetroTile btAlterar;
        public MetroFramework.Controls.MetroTile btExcluir;
        public MetroFramework.Controls.MetroTile btnVisualizar;
    }
}
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase));
            this.btnVisualizar = new MetroFramework.Controls.MetroTile();
            this.btExcluir = new MetroFramework.Controls.MetroTile();
            this.btAlterar = new MetroFramework.Controls.MetroTile();
            this.btNovo = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.ActiveControl = null;
            this.btnVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnVisualizar.Location = new System.Drawing.Point(31, 358);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(212, 64);
            this.btnVisualizar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnVisualizar.TabIndex = 59;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnVisualizar.UseCustomBackColor = true;
            this.btnVisualizar.UseSelectable = true;
            this.btnVisualizar.UseTileImage = true;
            // 
            // btExcluir
            // 
            this.btExcluir.ActiveControl = null;
            this.btExcluir.Location = new System.Drawing.Point(139, 241);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(104, 110);
            this.btExcluir.Style = MetroFramework.MetroColorStyle.Red;
            this.btExcluir.TabIndex = 58;
            this.btExcluir.Text = "Deletar";
            this.btExcluir.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btExcluir.UseSelectable = true;
            this.btExcluir.UseTileImage = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.ActiveControl = null;
            this.btAlterar.Location = new System.Drawing.Point(31, 241);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(100, 110);
            this.btAlterar.Style = MetroFramework.MetroColorStyle.Silver;
            this.btAlterar.TabIndex = 57;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btAlterar.UseSelectable = true;
            this.btAlterar.UseTileImage = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btNovo
            // 
            this.btNovo.ActiveControl = null;
            this.btNovo.Location = new System.Drawing.Point(31, 132);
            this.btNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(212, 101);
            this.btNovo.Style = MetroFramework.MetroColorStyle.Blue;
            this.btNovo.TabIndex = 56;
            this.btNovo.Text = "Novo";
            this.btNovo.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btNovo.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btNovo.UseSelectable = true;
            this.btNovo.UseTileImage = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 494);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btNovo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBase";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Base";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroTile btNovo;
        public MetroFramework.Controls.MetroTile btAlterar;
        public MetroFramework.Controls.MetroTile btExcluir;
        public MetroFramework.Controls.MetroTile btnVisualizar;
        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        public MetroFramework.Components.MetroStyleExtender metroStyleExtender;
    }
}
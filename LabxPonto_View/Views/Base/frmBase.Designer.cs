namespace LabxPonto_View.Views.Base
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
            this.btNovo = new MetroFramework.Controls.MetroTile();
            this.btAlterar = new MetroFramework.Controls.MetroTile();
            this.btExcluir = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btNovo
            // 
            this.btNovo.ActiveControl = null;
            this.btNovo.Location = new System.Drawing.Point(23, 107);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(156, 108);
            this.btNovo.Style = MetroFramework.MetroColorStyle.Blue;
            this.btNovo.TabIndex = 56;
            this.btNovo.Text = "Novo";
            this.btNovo.UseSelectable = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.ActiveControl = null;
            this.btAlterar.Location = new System.Drawing.Point(23, 221);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 65);
            this.btAlterar.Style = MetroFramework.MetroColorStyle.Silver;
            this.btAlterar.TabIndex = 57;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseSelectable = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.ActiveControl = null;
            this.btExcluir.Location = new System.Drawing.Point(104, 221);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 65);
            this.btExcluir.Style = MetroFramework.MetroColorStyle.Red;
            this.btExcluir.TabIndex = 58;
            this.btExcluir.Text = "Deletar";
            this.btExcluir.UseSelectable = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 312);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btNovo);
            this.Name = "frmBase";
            this.Text = "Base";
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroTile btNovo;
        public MetroFramework.Controls.MetroTile btAlterar;
        public MetroFramework.Controls.MetroTile btExcluir;
    }
}
namespace LabxPonto_View.Views
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
            this.mtCadastro = new MetroFramework.Controls.MetroTile();
            this.mtConfiguracoes = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mtCadastro
            // 
            this.mtCadastro.ActiveControl = null;
            this.mtCadastro.Location = new System.Drawing.Point(209, 185);
            this.mtCadastro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtCadastro.Name = "mtCadastro";
            this.mtCadastro.Size = new System.Drawing.Size(180, 123);
            this.mtCadastro.TabIndex = 1;
            this.mtCadastro.Text = "Cadastros";
            this.mtCadastro.UseSelectable = true;
            this.mtCadastro.Click += new System.EventHandler(this.mtCadastro_Click);
            // 
            // mtConfiguracoes
            // 
            this.mtConfiguracoes.ActiveControl = null;
            this.mtConfiguracoes.Location = new System.Drawing.Point(17, 185);
            this.mtConfiguracoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtConfiguracoes.Name = "mtConfiguracoes";
            this.mtConfiguracoes.Size = new System.Drawing.Size(188, 123);
            this.mtConfiguracoes.TabIndex = 2;
            this.mtConfiguracoes.Text = "Configurações";
            this.mtConfiguracoes.TileImage = global::LabxPonto_View.Properties.Resources.config;
            this.mtConfiguracoes.UseSelectable = true;
            this.mtConfiguracoes.UseTileImage = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(17, 313);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(372, 79);
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "Relatórios";
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(394, 185);
            this.metroTile3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(180, 123);
            this.metroTile3.TabIndex = 5;
            this.metroTile3.Text = "Leitura de Arquivo";
            this.metroTile3.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(394, 39);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(180, 141);
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Text = "Gerar Arquivo";
            this.metroTile2.UseSelectable = true;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::LabxPonto_View.Properties.Resources.LogoEmpresa;
            this.pbLogo.Location = new System.Drawing.Point(17, 39);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(372, 141);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 447);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mtConfiguracoes);
            this.Controls.Add(this.mtCadastro);
            this.Controls.Add(this.pbLogo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Default;
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private MetroFramework.Controls.MetroTile mtConfiguracoes;
        private MetroFramework.Controls.MetroTile metroTile1;
        public MetroFramework.Controls.MetroTile mtCadastro;
        public MetroFramework.Controls.MetroTile metroTile2;
        public MetroFramework.Controls.MetroTile metroTile3;
    }
}
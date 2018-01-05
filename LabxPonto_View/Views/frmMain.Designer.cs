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
            this.btnFuncionario = new MetroFramework.Controls.MetroTile();
            this.mtConfiguracoes = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnDepartamento = new MetroFramework.Controls.MetroTile();
            this.btnEmpresa = new MetroFramework.Controls.MetroTile();
            this.btnFuncoes = new MetroFramework.Controls.MetroTile();
            this.btnSair = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.ActiveControl = null;
            this.btnFuncionario.Location = new System.Drawing.Point(394, 185);
            this.btnFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(180, 123);
            this.btnFuncionario.TabIndex = 1;
            this.btnFuncionario.Text = "Funcionários";
            this.btnFuncionario.UseSelectable = true;
            this.btnFuncionario.Click += new System.EventHandler(this.mtCadastro_Click);
            // 
            // mtConfiguracoes
            // 
            this.mtConfiguracoes.ActiveControl = null;
            this.mtConfiguracoes.Location = new System.Drawing.Point(17, 185);
            this.mtConfiguracoes.Margin = new System.Windows.Forms.Padding(2);
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
            this.metroTile1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(372, 79);
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "Relatórios";
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(209, 185);
            this.metroTile3.Margin = new System.Windows.Forms.Padding(2);
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
            // btnDepartamento
            // 
            this.btnDepartamento.ActiveControl = null;
            this.btnDepartamento.Location = new System.Drawing.Point(394, 313);
            this.btnDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnDepartamento.Name = "btnDepartamento";
            this.btnDepartamento.Size = new System.Drawing.Size(180, 79);
            this.btnDepartamento.TabIndex = 6;
            this.btnDepartamento.Text = "Departamentos";
            this.btnDepartamento.UseSelectable = true;
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.ActiveControl = null;
            this.btnEmpresa.Location = new System.Drawing.Point(578, 251);
            this.btnEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(180, 141);
            this.btnEmpresa.TabIndex = 7;
            this.btnEmpresa.Text = "Empresas";
            this.btnEmpresa.UseSelectable = true;
            // 
            // btnFuncoes
            // 
            this.btnFuncoes.ActiveControl = null;
            this.btnFuncoes.Location = new System.Drawing.Point(578, 96);
            this.btnFuncoes.Margin = new System.Windows.Forms.Padding(2);
            this.btnFuncoes.Name = "btnFuncoes";
            this.btnFuncoes.Size = new System.Drawing.Size(180, 151);
            this.btnFuncoes.TabIndex = 8;
            this.btnFuncoes.Text = "Funções";
            this.btnFuncoes.UseSelectable = true;
            // 
            // btnSair
            // 
            this.btnSair.ActiveControl = null;
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(578, 39);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(180, 53);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseSelectable = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 415);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFuncoes);
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.btnDepartamento);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mtConfiguracoes);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.pbLogo);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        public MetroFramework.Controls.MetroTile btnFuncionario;
        public MetroFramework.Controls.MetroTile metroTile2;
        public MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile btnDepartamento;
        public MetroFramework.Controls.MetroTile btnEmpresa;
        public MetroFramework.Controls.MetroTile btnFuncoes;
        public MetroFramework.Controls.MetroTile btnSair;
    }
}
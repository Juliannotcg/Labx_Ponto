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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.btnDepartamento = new MetroFramework.Controls.MetroTile();
            this.btnEmpresa = new MetroFramework.Controls.MetroTile();
            this.btnFuncoes = new MetroFramework.Controls.MetroTile();
            this.btnSair = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtConfiguracoes = new MetroFramework.Controls.MetroTile();
            this.btnFuncionario = new MetroFramework.Controls.MetroTile();
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btTema = new MetroFramework.Controls.MetroTile();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.metroTile1.Location = new System.Drawing.Point(635, 431);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(175, 97);
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "Relatórios";
            this.metroToolTip1.SetToolTip(this.metroTile1, "Gerar relatórios");
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(635, 274);
            this.metroTile3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(175, 151);
            this.metroTile3.TabIndex = 5;
            this.metroTile3.Text = "Leitura de Arquivo";
            this.metroToolTip1.SetToolTip(this.metroTile3, "Ler arquivo");
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.metroTile2.Location = new System.Drawing.Point(455, 274);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(175, 151);
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Text = "Gerar Arquivo";
            this.metroToolTip1.SetToolTip(this.metroTile2, "Gerar arquivo");
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // btnDepartamento
            // 
            this.btnDepartamento.ActiveControl = null;
            this.btnDepartamento.Location = new System.Drawing.Point(24, 431);
            this.btnDepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDepartamento.Name = "btnDepartamento";
            this.btnDepartamento.Size = new System.Drawing.Size(185, 97);
            this.btnDepartamento.TabIndex = 6;
            this.btnDepartamento.Text = "Departamentos";
            this.metroToolTip1.SetToolTip(this.btnDepartamento, "Cadastro de departamentos");
            this.btnDepartamento.UseSelectable = true;
            this.btnDepartamento.Click += new System.EventHandler(this.btnDepartamento_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.ActiveControl = null;
            this.btnEmpresa.Location = new System.Drawing.Point(215, 274);
            this.btnEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(185, 151);
            this.btnEmpresa.TabIndex = 7;
            this.btnEmpresa.Text = "Empresas";
            this.metroToolTip1.SetToolTip(this.btnEmpresa, "Cadastro de empresas");
            this.btnEmpresa.UseSelectable = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // btnFuncoes
            // 
            this.btnFuncoes.ActiveControl = null;
            this.btnFuncoes.Location = new System.Drawing.Point(215, 431);
            this.btnFuncoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFuncoes.Name = "btnFuncoes";
            this.btnFuncoes.Size = new System.Drawing.Size(185, 97);
            this.btnFuncoes.TabIndex = 8;
            this.btnFuncoes.Text = "Funções";
            this.metroToolTip1.SetToolTip(this.btnFuncoes, "Cadastro de funções");
            this.btnFuncoes.UseSelectable = true;
            this.btnFuncoes.Click += new System.EventHandler(this.btnFuncoes_Click);
            // 
            // btnSair
            // 
            this.btnSair.ActiveControl = null;
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(635, 647);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(175, 65);
            this.btnSair.Style = MetroFramework.MetroColorStyle.Red;
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.metroToolTip1.SetToolTip(this.btnSair, "Sair do sistema");
            this.btnSair.UseSelectable = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(24, 254);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 15);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Cadastros";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(455, 254);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(117, 15);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Arquivos / Relatórios";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(24, 546);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 15);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Sistema";
            // 
            // mtConfiguracoes
            // 
            this.mtConfiguracoes.ActiveControl = null;
            this.mtConfiguracoes.Location = new System.Drawing.Point(23, 567);
            this.mtConfiguracoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtConfiguracoes.Name = "mtConfiguracoes";
            this.mtConfiguracoes.Size = new System.Drawing.Size(377, 145);
            this.mtConfiguracoes.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtConfiguracoes.TabIndex = 2;
            this.mtConfiguracoes.Text = "Configurações";
            this.metroToolTip1.SetToolTip(this.mtConfiguracoes, "Acessar as configurações do sistema");
            this.mtConfiguracoes.UseSelectable = true;
            this.mtConfiguracoes.UseTileImage = true;
            this.mtConfiguracoes.Click += new System.EventHandler(this.mtConfiguracoes_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.ActiveControl = null;
            this.btnFuncionario.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFuncionario.Location = new System.Drawing.Point(24, 274);
            this.btnFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(185, 151);
            this.btnFuncionario.TabIndex = 1;
            this.btnFuncionario.Text = "Funcionários";
            this.metroToolTip1.SetToolTip(this.btnFuncionario, "Cadastro de funcionários");
            this.btnFuncionario.UseCustomBackColor = true;
            this.btnFuncionario.UseSelectable = true;
            this.btnFuncionario.UseTileImage = true;
            this.btnFuncionario.Click += new System.EventHandler(this.mtCadastro_Click);
            // 
            // pbLogo
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.pbLogo, true);
            this.pbLogo.Image = global::LabxPonto_View.Properties.Resources.Logo11;
            this.pbLogo.Location = new System.Drawing.Point(23, 48);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(787, 134);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // btTema
            // 
            this.btTema.ActiveControl = null;
            this.btTema.BackColor = System.Drawing.Color.Transparent;
            this.btTema.Location = new System.Drawing.Point(405, 659);
            this.btTema.Margin = new System.Windows.Forms.Padding(2);
            this.btTema.Name = "btTema";
            this.btTema.PaintTileCount = false;
            this.btTema.Size = new System.Drawing.Size(50, 53);
            this.btTema.TabIndex = 13;
            this.btTema.TileImage = global::LabxPonto_View.Properties.Resources.theme1;
            this.metroToolTip1.SetToolTip(this.btTema, "Alterar tema");
            this.btTema.UseCustomBackColor = true;
            this.btTema.UseMnemonic = false;
            this.btTema.UseSelectable = true;
            this.btTema.UseTileImage = true;
            this.btTema.Click += new System.EventHandler(this.btTema_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frmMain
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 739);
            this.Controls.Add(this.btTema);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Default;
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        public MetroFramework.Controls.MetroTile btTema;
        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}
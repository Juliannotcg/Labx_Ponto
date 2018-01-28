namespace LabxPonto_View.Views.Funcionarios
{
    partial class frmFuncionarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgFuncionarios = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCPF = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.btnImprimir = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(31, 100);
            this.btNovo.Margin = new System.Windows.Forms.Padding(5);
            this.btNovo.Size = new System.Drawing.Size(225, 101);
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click_1);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(31, 208);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(5);
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click_2);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(139, 208);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(5);
            this.btExcluir.Size = new System.Drawing.Size(117, 110);
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click_2);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(31, 326);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(5);
            this.btnVisualizar.Size = new System.Drawing.Size(225, 58);
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(12, 404);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Size = new System.Drawing.Size(108, 44);
            // 
            // dgFuncionarios
            // 
            this.dgFuncionarios.AllowUserToAddRows = false;
            this.dgFuncionarios.AllowUserToDeleteRows = false;
            this.dgFuncionarios.AllowUserToOrderColumns = true;
            this.dgFuncionarios.AllowUserToResizeRows = false;
            this.dgFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgFuncionarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgFuncionarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgFuncionarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Empresa,
            this.Departamento,
            this.Funcao});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgFuncionarios.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgFuncionarios.EnableHeadersVisualStyles = false;
            this.dgFuncionarios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgFuncionarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgFuncionarios.Location = new System.Drawing.Point(264, 100);
            this.dgFuncionarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgFuncionarios.Name = "dgFuncionarios";
            this.dgFuncionarios.ReadOnly = true;
            this.dgFuncionarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFuncionarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgFuncionarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFuncionarios.Size = new System.Drawing.Size(935, 264);
            this.dgFuncionarios.TabIndex = 61;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // Empresa
            // 
            this.Empresa.DataPropertyName = "Empresa";
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            this.Empresa.Width = 200;
            // 
            // Departamento
            // 
            this.Departamento.DataPropertyName = "Departamento";
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            this.Departamento.Width = 150;
            // 
            // Funcao
            // 
            this.Funcao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Funcao.DataPropertyName = "Funcao";
            this.Funcao.HeaderText = "Função";
            this.Funcao.Name = "Funcao";
            this.Funcao.ReadOnly = true;
            // 
            // txtCPF
            // 
            // 
            // 
            // 
            this.txtCPF.CustomButton.Image = global::LabxPonto_View.Properties.Resources.if_icons_search_1564527;
            this.txtCPF.CustomButton.Location = new System.Drawing.Point(273, 2);
            this.txtCPF.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCPF.CustomButton.Name = "";
            this.txtCPF.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtCPF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCPF.CustomButton.TabIndex = 1;
            this.txtCPF.CustomButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txtCPF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCPF.CustomButton.UseSelectable = true;
            this.txtCPF.CustomButton.UseVisualStyleBackColor = false;
            this.txtCPF.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCPF.Lines = new string[0];
            this.txtCPF.Location = new System.Drawing.Point(264, 58);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCPF.MaxLength = 32767;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.PasswordChar = '\0';
            this.txtCPF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCPF.SelectedText = "";
            this.txtCPF.SelectionLength = 0;
            this.txtCPF.SelectionStart = 0;
            this.txtCPF.ShortcutsEnabled = true;
            this.txtCPF.ShowButton = true;
            this.txtCPF.Size = new System.Drawing.Size(307, 36);
            this.txtCPF.TabIndex = 66;
            this.txtCPF.UseSelectable = true;
            this.txtCPF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCPF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCPF.Click += new System.EventHandler(this.txtCPF_Click);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Location = new System.Drawing.Point(265, 32);
            this.metroLabel26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(33, 20);
            this.metroLabel26.TabIndex = 67;
            this.metroLabel26.Text = "CPF";
            this.metroLabel26.UseCustomBackColor = true;
            this.metroLabel26.UseCustomForeColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::LabxPonto_View.Properties.Resources.printer;
            this.btnImprimir.ImageSize = 40;
            this.btnImprimir.Location = new System.Drawing.Point(583, 46);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.NoFocusImage = global::LabxPonto_View.Properties.Resources.printer__1_;
            this.btnImprimir.Size = new System.Drawing.Size(68, 51);
            this.btnImprimir.TabIndex = 68;
            this.btnImprimir.UseSelectable = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 457);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.metroLabel26);
            this.Controls.Add(this.dgFuncionarios);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmFuncionarios";
            this.Padding = new System.Windows.Forms.Padding(36, 91, 36, 31);
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.frmFuncionarios_Load);
            this.Controls.SetChildIndex(this.dgFuncionarios, 0);
            this.Controls.SetChildIndex(this.pbLogo, 0);
            this.Controls.SetChildIndex(this.btnVisualizar, 0);
            this.Controls.SetChildIndex(this.btNovo, 0);
            this.Controls.SetChildIndex(this.btAlterar, 0);
            this.Controls.SetChildIndex(this.btExcluir, 0);
            this.Controls.SetChildIndex(this.metroLabel26, 0);
            this.Controls.SetChildIndex(this.txtCPF, 0);
            this.Controls.SetChildIndex(this.btnImprimir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroGrid dgFuncionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcao;
        private MetroFramework.Controls.MetroTextBox txtCPF;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        public MetroFramework.Controls.MetroTile btVoltar;
        private MetroFramework.Controls.MetroLink btnImprimir;
    }
}
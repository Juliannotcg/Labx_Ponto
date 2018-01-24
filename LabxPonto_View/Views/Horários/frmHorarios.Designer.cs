namespace LabxPonto_View.Views.Horários
{
    partial class frmHorarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHorarios));
            this.dgFuncionarios = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.gbFuncionario = new System.Windows.Forms.GroupBox();
            this.txtCPF = new MetroFramework.Controls.MetroTextBox();
            this.dpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel33 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroLabel();
            this.txtEmpresa = new MetroFramework.Controls.MetroLabel();
            this.txtDepartamento = new MetroFramework.Controls.MetroLabel();
            this.txtFuncao = new MetroFramework.Controls.MetroLabel();
            this.errorProviderFunc = new System.Windows.Forms.ErrorProvider(this.components);
            this.btAlterar = new MetroFramework.Controls.MetroTile();
            this.btExcluir = new MetroFramework.Controls.MetroTile();
            this.btNovo = new MetroFramework.Controls.MetroTile();
            this.imgFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionarios)).BeginInit();
            this.gbFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFuncionarios
            // 
            this.dgFuncionarios.AllowUserToAddRows = false;
            this.dgFuncionarios.AllowUserToDeleteRows = false;
            this.dgFuncionarios.AllowUserToResizeRows = false;
            this.dgFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgFuncionarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgFuncionarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgFuncionarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Data,
            this.Endrada,
            this.Saida});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgFuncionarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgFuncionarios.EnableHeadersVisualStyles = false;
            this.dgFuncionarios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgFuncionarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgFuncionarios.Location = new System.Drawing.Point(31, 328);
            this.dgFuncionarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgFuncionarios.Name = "dgFuncionarios";
            this.dgFuncionarios.ReadOnly = true;
            this.dgFuncionarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFuncionarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgFuncionarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFuncionarios.Size = new System.Drawing.Size(1069, 444);
            this.dgFuncionarios.TabIndex = 62;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 200;
            // 
            // Endrada
            // 
            this.Endrada.DataPropertyName = "Entrada";
            this.Endrada.HeaderText = "Entrada";
            this.Endrada.Name = "Endrada";
            this.Endrada.ReadOnly = true;
            this.Endrada.Width = 200;
            // 
            // Saida
            // 
            this.Saida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Saida.DataPropertyName = "Saida";
            this.Saida.HeaderText = "Saída";
            this.Saida.Name = "Saida";
            this.Saida.ReadOnly = true;
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Location = new System.Drawing.Point(20, 87);
            this.metroLabel26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(33, 20);
            this.metroLabel26.TabIndex = 65;
            this.metroLabel26.Text = "CPF";
            this.metroLabel26.UseCustomBackColor = true;
            this.metroLabel26.UseCustomForeColor = true;
            // 
            // gbFuncionario
            // 
            this.gbFuncionario.Controls.Add(this.txtCPF);
            this.gbFuncionario.Controls.Add(this.dpDataFinal);
            this.gbFuncionario.Controls.Add(this.dpDataInicial);
            this.gbFuncionario.Controls.Add(this.metroLabel1);
            this.gbFuncionario.Controls.Add(this.metroLabel33);
            this.gbFuncionario.Controls.Add(this.metroLabel26);
            this.gbFuncionario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbFuncionario.Location = new System.Drawing.Point(31, 78);
            this.gbFuncionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFuncionario.Name = "gbFuncionario";
            this.gbFuncionario.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFuncionario.Size = new System.Drawing.Size(351, 182);
            this.gbFuncionario.TabIndex = 66;
            this.gbFuncionario.TabStop = false;
            this.gbFuncionario.Text = "Dados de pesquisa";
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
            this.txtCPF.Location = new System.Drawing.Point(20, 113);
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
            this.txtCPF.TabIndex = 2;
            this.txtCPF.UseSelectable = true;
            this.txtCPF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCPF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // dpDataFinal
            // 
            this.dpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDataFinal.Location = new System.Drawing.Point(175, 59);
            this.dpDataFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpDataFinal.Name = "dpDataFinal";
            this.dpDataFinal.Size = new System.Drawing.Size(151, 22);
            this.dpDataFinal.TabIndex = 1;
            // 
            // dpDataInicial
            // 
            this.dpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDataInicial.Location = new System.Drawing.Point(20, 59);
            this.dpDataInicial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpDataInicial.Name = "dpDataInicial";
            this.dpDataInicial.Size = new System.Drawing.Size(140, 22);
            this.dpDataInicial.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(175, 32);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 20);
            this.metroLabel1.TabIndex = 69;
            this.metroLabel1.Text = "Data final";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel33
            // 
            this.metroLabel33.AutoSize = true;
            this.metroLabel33.Location = new System.Drawing.Point(20, 32);
            this.metroLabel33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel33.Name = "metroLabel33";
            this.metroLabel33.Size = new System.Drawing.Size(75, 20);
            this.metroLabel33.TabIndex = 67;
            this.metroLabel33.Text = "Data inicial";
            this.metroLabel33.UseCustomBackColor = true;
            this.metroLabel33.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(584, 89);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 20);
            this.metroLabel2.TabIndex = 68;
            this.metroLabel2.Text = "Nome:";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(584, 137);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 20);
            this.metroLabel3.TabIndex = 69;
            this.metroLabel3.Text = "Empresa:";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(585, 180);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(94, 20);
            this.metroLabel4.TabIndex = 70;
            this.metroLabel4.Text = "Departameto:";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(585, 226);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(57, 20);
            this.metroLabel5.TabIndex = 71;
            this.metroLabel5.Text = "Função:";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.txtNome.Location = new System.Drawing.Point(676, 89);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(423, 30);
            this.txtNome.TabIndex = 72;
            this.txtNome.UseCustomBackColor = true;
            this.txtNome.UseCustomForeColor = true;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpresa.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.txtEmpresa.Location = new System.Drawing.Point(700, 137);
            this.txtEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(399, 30);
            this.txtEmpresa.TabIndex = 76;
            this.txtEmpresa.UseCustomBackColor = true;
            this.txtEmpresa.UseCustomForeColor = true;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartamento.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.txtDepartamento.Location = new System.Drawing.Point(748, 180);
            this.txtDepartamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(351, 30);
            this.txtDepartamento.TabIndex = 77;
            this.txtDepartamento.UseCustomBackColor = true;
            this.txtDepartamento.UseCustomForeColor = true;
            // 
            // txtFuncao
            // 
            this.txtFuncao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFuncao.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.txtFuncao.Location = new System.Drawing.Point(688, 226);
            this.txtFuncao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(411, 30);
            this.txtFuncao.TabIndex = 78;
            this.txtFuncao.UseCustomBackColor = true;
            this.txtFuncao.UseCustomForeColor = true;
            // 
            // errorProviderFunc
            // 
            this.errorProviderFunc.ContainerControl = this;
            this.errorProviderFunc.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderFunc.Icon")));
            // 
            // btAlterar
            // 
            this.btAlterar.ActiveControl = null;
            this.btAlterar.Location = new System.Drawing.Point(243, 265);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(199, 55);
            this.btAlterar.Style = MetroFramework.MetroColorStyle.Silver;
            this.btAlterar.TabIndex = 80;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAlterar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btAlterar.UseSelectable = true;
            this.btAlterar.UseTileImage = true;
            this.btAlterar.Visible = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.ActiveControl = null;
            this.btExcluir.Location = new System.Drawing.Point(450, 265);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(213, 55);
            this.btExcluir.Style = MetroFramework.MetroColorStyle.Red;
            this.btExcluir.TabIndex = 83;
            this.btExcluir.Text = "Deletar";
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btExcluir.UseSelectable = true;
            this.btExcluir.UseTileImage = true;
            this.btExcluir.Visible = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btNovo
            // 
            this.btNovo.ActiveControl = null;
            this.btNovo.Location = new System.Drawing.Point(31, 265);
            this.btNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(204, 55);
            this.btNovo.Style = MetroFramework.MetroColorStyle.Blue;
            this.btNovo.TabIndex = 81;
            this.btNovo.Text = "Inserir";
            this.btNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btNovo.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btNovo.UseSelectable = true;
            this.btNovo.UseTileImage = true;
            this.btNovo.Visible = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click_1);
            // 
            // imgFoto
            // 
            this.imgFoto.Image = global::LabxPonto_View.Properties.Resources.photo_1103596_960_720;
            this.imgFoto.Location = new System.Drawing.Point(388, 89);
            this.imgFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgFoto.Name = "imgFoto";
            this.imgFoto.Size = new System.Drawing.Size(189, 169);
            this.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFoto.TabIndex = 73;
            this.imgFoto.TabStop = false;
            // 
            // frmHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 800);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.txtFuncao);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.imgFoto);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.gbFuncionario);
            this.Controls.Add(this.dgFuncionarios);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHorarios";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Horários";
            this.Load += new System.EventHandler(this.frmHorarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionarios)).EndInit();
            this.gbFuncionario.ResumeLayout(false);
            this.gbFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroGrid dgFuncionarios;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private System.Windows.Forms.GroupBox gbFuncionario;
        private System.Windows.Forms.DateTimePicker dpDataFinal;
        private System.Windows.Forms.DateTimePicker dpDataInicial;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel33;
        private MetroFramework.Controls.MetroTextBox txtCPF;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel txtNome;
        private System.Windows.Forms.PictureBox imgFoto;
        private MetroFramework.Controls.MetroLabel txtEmpresa;
        private MetroFramework.Controls.MetroLabel txtDepartamento;
        private MetroFramework.Controls.MetroLabel txtFuncao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saida;
        private System.Windows.Forms.ErrorProvider errorProviderFunc;
        public MetroFramework.Controls.MetroTile btAlterar;
        public MetroFramework.Controls.MetroTile btExcluir;
        public MetroFramework.Controls.MetroTile btNovo;
    }
}
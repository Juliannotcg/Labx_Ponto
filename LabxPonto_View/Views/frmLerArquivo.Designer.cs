namespace LabxPonto_View.Views
{
    partial class frmLerArquivo
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
            this.Arquivo = new MetroFramework.Controls.MetroLabel();
            this.txtArquivo = new MetroFramework.Controls.MetroTextBox();
            this.btnBuscar = new MetroFramework.Controls.MetroTile();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Arquivo
            // 
            this.Arquivo.AutoSize = true;
            this.Arquivo.Location = new System.Drawing.Point(25, 95);
            this.Arquivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Arquivo.Name = "Arquivo";
            this.Arquivo.Size = new System.Drawing.Size(100, 20);
            this.Arquivo.TabIndex = 68;
            this.Arquivo.Text = "Buscar arquivo";
            this.Arquivo.UseCustomBackColor = true;
            this.Arquivo.UseCustomForeColor = true;
            // 
            // txtArquivo
            // 
            this.txtArquivo.AllowDrop = true;
            // 
            // 
            // 
            this.txtArquivo.CustomButton.Image = null;
            this.txtArquivo.CustomButton.Location = new System.Drawing.Point(623, 2);
            this.txtArquivo.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArquivo.CustomButton.Name = "";
            this.txtArquivo.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtArquivo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtArquivo.CustomButton.TabIndex = 1;
            this.txtArquivo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtArquivo.CustomButton.UseSelectable = true;
            this.txtArquivo.CustomButton.Visible = false;
            this.txtArquivo.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtArquivo.Lines = new string[0];
            this.txtArquivo.Location = new System.Drawing.Point(29, 121);
            this.txtArquivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArquivo.MaxLength = 255;
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.PasswordChar = '\0';
            this.txtArquivo.ReadOnly = true;
            this.txtArquivo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtArquivo.SelectedText = "";
            this.txtArquivo.SelectionLength = 0;
            this.txtArquivo.SelectionStart = 0;
            this.txtArquivo.ShortcutsEnabled = true;
            this.txtArquivo.Size = new System.Drawing.Size(657, 36);
            this.txtArquivo.TabIndex = 67;
            this.txtArquivo.UseSelectable = true;
            this.txtArquivo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtArquivo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtArquivo.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtArquivo_DragDrop);
            this.txtArquivo.DragOver += new System.Windows.Forms.DragEventHandler(this.txtArquivo_DragOver);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ActiveControl = null;
            this.btnBuscar.Location = new System.Drawing.Point(679, 121);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 36);
            this.btnBuscar.TabIndex = 69;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(627, 191);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 39);
            this.btnCancelar.TabIndex = 71;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(483, 191);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(125, 39);
            this.btnSalvar.TabIndex = 70;
            this.btnSalvar.Text = "Confirmar";
            this.btnSalvar.UseSelectable = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "\".\"";
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.InitialDirectory = "C:\\";
            // 
            // frmLerArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 258);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.Arquivo);
            this.Controls.Add(this.txtArquivo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLerArquivo";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Ler Arquivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Arquivo;
        private MetroFramework.Controls.MetroTextBox txtArquivo;
        public MetroFramework.Controls.MetroTile btnBuscar;
        public MetroFramework.Controls.MetroButton btnCancelar;
        public MetroFramework.Controls.MetroButton btnSalvar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
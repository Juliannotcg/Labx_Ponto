namespace LabxPonto_View.Views.Funções
{
    partial class frmRltFuncao
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.FuncaoRltBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerFuncao = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.FuncaoRltBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FuncaoRltBindingSource
            // 
            // 
            // reportViewerFuncao
            // 
            this.reportViewerFuncao.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetFuncao";
            reportDataSource1.Value = this.FuncaoRltBindingSource;
            this.reportViewerFuncao.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerFuncao.LocalReport.ReportEmbeddedResource = "LabxPonto_View.Views.Funções.ReportFuncao.rdlc";
            this.reportViewerFuncao.Location = new System.Drawing.Point(0, 0);
            this.reportViewerFuncao.Name = "reportViewerFuncao";
            this.reportViewerFuncao.ServerReport.BearerToken = null;
            this.reportViewerFuncao.Size = new System.Drawing.Size(843, 758);
            this.reportViewerFuncao.TabIndex = 1;
            // 
            // frmRltFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 758);
            this.Controls.Add(this.reportViewerFuncao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRltFuncao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRltFuncao_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.FuncaoRltBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerFuncao;
        private System.Windows.Forms.BindingSource FuncaoRltBindingSource;
    }
}
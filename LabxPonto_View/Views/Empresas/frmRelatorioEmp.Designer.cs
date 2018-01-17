namespace LabxPonto_View.Views.Empresas
{
    partial class frmRelatorioEmp
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
            this.reportViewerEmpresa = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerEmpresa
            // 
            this.reportViewerEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerEmpresa.Location = new System.Drawing.Point(0, 0);
            this.reportViewerEmpresa.Name = "reportViewerEmpresa";
            this.reportViewerEmpresa.ServerReport.BearerToken = null;
            this.reportViewerEmpresa.Size = new System.Drawing.Size(654, 572);
            this.reportViewerEmpresa.TabIndex = 0;
            // 
            // frmRelatorioEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 572);
            this.Controls.Add(this.reportViewerEmpresa);
            this.Name = "frmRelatorioEmp";
            this.Text = "frmRelatorioEmp";
            this.Load += new System.EventHandler(this.frmRelatorioEmp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerEmpresa;
    }
}
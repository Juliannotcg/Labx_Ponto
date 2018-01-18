namespace LabxPonto_View.Views.Funcionarios
{
    partial class frmRltFuncionario
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewerFuncionario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerFuncionario
            // 
            this.reportViewerFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetFuncao";
            reportDataSource1.Value = null;
            this.reportViewerFuncionario.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerFuncionario.LocalReport.ReportEmbeddedResource = "LabxPonto_View.Views.Funções.ReportFuncao.rdlc";
            this.reportViewerFuncionario.Location = new System.Drawing.Point(0, 0);
            this.reportViewerFuncionario.Name = "reportViewerFuncionario";
            this.reportViewerFuncionario.ServerReport.BearerToken = null;
            this.reportViewerFuncionario.Size = new System.Drawing.Size(892, 651);
            this.reportViewerFuncionario.TabIndex = 2;
            this.reportViewerFuncionario.Load += new System.EventHandler(this.reportViewerFuncionario_Load);
            // 
            // frmRltFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 651);
            this.Controls.Add(this.reportViewerFuncionario);
            this.Name = "frmRltFuncionario";
            this.Text = "frmRltFuncionario";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerFuncionario;
    }
}
namespace LabxPonto_View.Views.Funcionarios
{
    partial class frmRltFuncionarioEmpresa
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
            this.RltFuncionarioEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerFuncionarioEmpresa = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.RltFuncionarioEmpresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RltFuncionarioEmpresaBindingSource
            // 
            this.RltFuncionarioEmpresaBindingSource.DataSource = typeof(LabxPonto_Dao.Model.ModelRelatorio.RltFuncionarioEmpresa);
            // 
            // reportViewerFuncionarioEmpresa
            // 
            this.reportViewerFuncionarioEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetFuncionarioEmpresa";
            reportDataSource1.Value = this.RltFuncionarioEmpresaBindingSource;
            this.reportViewerFuncionarioEmpresa.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerFuncionarioEmpresa.LocalReport.ReportEmbeddedResource = "LabxPonto_View.Views.Funcionarios.RltFuncionarioEmpresa.rdlc";
            this.reportViewerFuncionarioEmpresa.Location = new System.Drawing.Point(0, 0);
            this.reportViewerFuncionarioEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewerFuncionarioEmpresa.Name = "reportViewerFuncionarioEmpresa";
            this.reportViewerFuncionarioEmpresa.ServerReport.BearerToken = null;
            this.reportViewerFuncionarioEmpresa.Size = new System.Drawing.Size(504, 352);
            this.reportViewerFuncionarioEmpresa.TabIndex = 3;
            this.reportViewerFuncionarioEmpresa.Load += new System.EventHandler(this.reportViewerFuncionarioEmpresa_Load);
            // 
            // frmRltFuncionarioEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 352);
            this.Controls.Add(this.reportViewerFuncionarioEmpresa);
            this.Name = "frmRltFuncionarioEmpresa";
            this.Text = "frmRltFuncionarioEmpresa";
            this.Load += new System.EventHandler(this.frmRltFuncionarioEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RltFuncionarioEmpresaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerFuncionarioEmpresa;
        private System.Windows.Forms.BindingSource RltFuncionarioEmpresaBindingSource;
    }
}
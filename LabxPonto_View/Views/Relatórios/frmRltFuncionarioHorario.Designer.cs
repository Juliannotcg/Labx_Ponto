namespace LabxPonto_View.Views.Relatórios
{
    partial class frmRltFuncionarioHorario
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
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DadosRelatorioFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DadosRelatorioFuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetHorasFuncionario";
            reportDataSource1.Value = this.DadosRelatorioFuncionarioBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "LabxPonto_View.Report.rltFuncionario.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(20, 60);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(843, 713);
            this.reportViewer.TabIndex = 0;
            // 
            // DadosRelatorioFuncionarioBindingSource
            // 
            this.DadosRelatorioFuncionarioBindingSource.DataSource = typeof(LabxPonto_Dao.Model.Report.DadosRelatorioFuncionario);
            // 
            // frmRltFuncionarioHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 793);
            this.Controls.Add(this.reportViewer);
            this.Name = "frmRltFuncionarioHorario";
            this.Load += new System.EventHandler(this.frmRltFuncionarioHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DadosRelatorioFuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource DadosRelatorioFuncionarioBindingSource;
    }
}
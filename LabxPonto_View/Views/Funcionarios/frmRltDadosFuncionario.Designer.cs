namespace LabxPonto_View.Views.Funcionarios
{
    partial class frmRltDadosFuncionario
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
            this.reportViewerDadosFuncionario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RltDadosFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RltDadosFuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerDadosFuncionario
            // 
            this.reportViewerDadosFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDadosFuncionario";
            reportDataSource1.Value = this.RltDadosFuncionarioBindingSource;
            this.reportViewerDadosFuncionario.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerDadosFuncionario.LocalReport.ReportEmbeddedResource = "LabxPonto_View.Views.Funcionarios.RltDadosFuncionario.rdlc";
            this.reportViewerDadosFuncionario.Location = new System.Drawing.Point(0, 0);
            this.reportViewerDadosFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewerDadosFuncionario.Name = "reportViewerDadosFuncionario";
            this.reportViewerDadosFuncionario.ServerReport.BearerToken = null;
            this.reportViewerDadosFuncionario.Size = new System.Drawing.Size(957, 577);
            this.reportViewerDadosFuncionario.TabIndex = 3;
            this.reportViewerDadosFuncionario.Load += new System.EventHandler(this.reportViewerDadosFuncionario_Load);
            // 
            // RltDadosFuncionarioBindingSource
            // 
            this.RltDadosFuncionarioBindingSource.DataSource = typeof(LabxPonto_Dao.Model.ModelRelatorio.RltDadosFuncionario);
            // 
            // frmRltDadosFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 577);
            this.Controls.Add(this.reportViewerDadosFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRltDadosFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de funcionário";
            this.Load += new System.EventHandler(this.frmRltDadosFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RltDadosFuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDadosFuncionario;
        private System.Windows.Forms.BindingSource RltDadosFuncionarioBindingSource;
    }
}
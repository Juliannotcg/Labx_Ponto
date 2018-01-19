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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.FuncionarioRltBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerFuncionario = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionarioRltBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FuncionarioRltBindingSource
            // 
            // 
            // reportViewerFuncionario
            // 
            this.reportViewerFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetFuncionario";
            reportDataSource1.Value = this.FuncionarioRltBindingSource;
            this.reportViewerFuncionario.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerFuncionario.LocalReport.ReportEmbeddedResource = "LabxPonto_View.Views.Funcionarios.ReportFuncionario.rdlc";
            this.reportViewerFuncionario.Location = new System.Drawing.Point(0, 0);
            this.reportViewerFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRltFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Funcionario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRltFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FuncionarioRltBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerFuncionario;
        private System.Windows.Forms.BindingSource FuncionarioRltBindingSource;
    }
}
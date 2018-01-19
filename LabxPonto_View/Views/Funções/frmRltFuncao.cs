using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Service;
using System;
using System.Windows.Forms;

namespace LabxPonto_View.Views.Funções
{
    public partial class frmRltFuncao : Form
    {
        private AppDataContext context;
        private FuncaoService servico;
        public frmRltFuncao(AppDataContext con)
        {
            context = con;
            InitializeComponent();
        }

        private void frmRltFuncao_Load_1(object sender, EventArgs e)
        {
            servico = new FuncaoService(context);

            var resposta = servico.GetRelatorio();

            var dataSource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetFuncao", resposta);
            this.reportViewerFuncao.LocalReport.DataSources.Clear();
            this.reportViewerFuncao.LocalReport.DataSources.Add(dataSource);
            this.reportViewerFuncao.RefreshReport();
        }
    }
}

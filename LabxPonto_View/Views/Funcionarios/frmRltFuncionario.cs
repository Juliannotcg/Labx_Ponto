using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Service;
using System;
using System.Windows.Forms;

namespace LabxPonto_View.Views.Funcionarios
{
    public partial class frmRltFuncionario : Form
    {
        private FuncionarioService service;
        private AppDataContext context;
        private string CPF = "";
        private DateTime DataIni;
        private DateTime DataFim;

        public frmRltFuncionario(AppDataContext con, string cpf, DateTime dataIni, DateTime dataFim)
        {
            DataIni = dataIni;
            DataFim = dataFim;
            CPF = cpf;
            context = con;
            InitializeComponent();
        }

        private void reportViewerFuncionario_Load(object sender, EventArgs e)
        {
            service = new FuncionarioService(context);

            var resposta = service.GetRelatorio(CPF, DataIni, DataFim);

            var dataSource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetFuncionario", resposta);
            this.reportViewerFuncionario.LocalReport.DataSources.Clear();
            this.reportViewerFuncionario.LocalReport.DataSources.Add(dataSource);

            this.reportViewerFuncionario.RefreshReport();
        }

        private void frmRltFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}

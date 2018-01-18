using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Service;
using LabxPonto_View.ModelRlt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabxPonto_View.Views.Funcionarios
{
    public partial class frmRltFuncionario : Form
    {
        private FuncionarioService service;
        private AppDataContext context;
        private string CPF = "";

        public frmRltFuncionario(AppDataContext con, string cpf)
        {
            CPF = cpf;
            context = con;
            InitializeComponent();
        }

        private void reportViewerFuncionario_Load(object sender, EventArgs e)
        {
            service = new FuncionarioService(context);

            var resposta = service.GetRelatorio(CPF);

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

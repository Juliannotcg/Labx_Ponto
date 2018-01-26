using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Service;
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
    public partial class frmRltFuncionarioEmpresa : Form
    {
        private FuncionarioService service;
        private AppDataContext context;
        private string CNPJ = "";

        public frmRltFuncionarioEmpresa(AppDataContext _context, string cnpj)
        {
            context = _context;
            CNPJ = cnpj;
            InitializeComponent();
        }

        private void frmRltFuncionarioEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void reportViewerFuncionarioEmpresa_Load(object sender, EventArgs e)
        {

            service = new FuncionarioService(context);

            var resposta = service.GetRelatorioFuncEmpresa(CNPJ);

            var dataSource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetFuncionarioEmpresa", resposta);
            this.reportViewerFuncionarioEmpresa.LocalReport.DataSources.Clear();
            this.reportViewerFuncionarioEmpresa.LocalReport.DataSources.Add(dataSource);

            this.reportViewerFuncionarioEmpresa.RefreshReport();
        }
    }
}

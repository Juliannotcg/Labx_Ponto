using LabxPonto_Dao.Model.ModelRelatorio;
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
    public partial class frmRltDadosFuncionario : Form
    {
        private List<RltDadosFuncionario> dadosFuncionario;

        public frmRltDadosFuncionario(List<RltDadosFuncionario> _dadosFuncionario)
        {
            dadosFuncionario = _dadosFuncionario;
            InitializeComponent();
        }

        private void reportViewerDadosFuncionario_Load(object sender, EventArgs e)
        {
            var dataSource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetDadosFuncionario", dadosFuncionario);
            this.reportViewerDadosFuncionario.LocalReport.DataSources.Clear();
            this.reportViewerDadosFuncionario.LocalReport.DataSources.Add(dataSource);

            this.reportViewerDadosFuncionario.RefreshReport();
        }

        private void frmRltDadosFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}

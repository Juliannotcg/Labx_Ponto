using LabxPonto_Dao.Data.Context;
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
        public frmRltFuncionario()
        {
            InitializeComponent();
        }

        private void reportViewerFuncionario_Load(object sender, EventArgs e)
        {
            using (var context = new AppDataContext())
            {
                var resposta = (from c in context.HorariosExpediente
                                select new FuncionarioRlt()
                                {
                                    IdFuncionario = c.Funcionario.Id,
                                    Funcionario = c.Funcionario.Nome,
                                    Data = c.Data,
                                    Entrada = c.Entrada,
                                    Saida = c.Saida
                                }).ToArray();

                var dataSource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetFuncionario", resposta);
                this.reportViewerFuncionario.LocalReport.DataSources.Clear();
                this.reportViewerFuncionario.LocalReport.DataSources.Add(dataSource);

            }
            this.reportViewerFuncionario.RefreshReport();
        }
    }
}

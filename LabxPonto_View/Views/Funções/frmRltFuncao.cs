using LabxPonto_Dao.Data.Context;
using LabxPonto_View.ModelRlt;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabxPonto_View.Views.Funções
{
    public partial class frmRltFuncao : Form
    {
        public frmRltFuncao()
        {
            InitializeComponent();
        }

        private void frmRltFuncao_Load_1(object sender, EventArgs e)
        {
            using (var context = new AppDataContext())
            {
                var resposta = (from c in context.Funcoes
                                select new FuncaoRlt()
                                {
                                    IdDepartamento = c.Departamento.Id,
                                    NomeFuncao = c.NomeFuncao,
                                    Descricao = c.Descricao,
                                    Departamento = c.Departamento.NomeDepartamento
                                }).ToArray();

                var dataSource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetFuncao", resposta);
                this.reportViewerFuncao.LocalReport.DataSources.Clear();
                this.reportViewerFuncao.LocalReport.DataSources.Add(dataSource);

            }
            this.reportViewerFuncao.RefreshReport();
        }
    }
}

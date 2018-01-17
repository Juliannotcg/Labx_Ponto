using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabxPonto_View.Views.Empresas
{
    public partial class frmRelatorioEmp : Form
    {
        public frmRelatorioEmp()
        {
            InitializeComponent();
        }

        private void frmRelatorioEmp_Load(object sender, EventArgs e)
        {

            this.reportViewerEmpresa.RefreshReport();
        }
    }
}

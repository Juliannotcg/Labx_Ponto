using LabxPonto_Dao.Model;
using LabxPonto_Dao.Service;
using LabxPonto_View.Views.Base;
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
    public partial class frmFuncionarioCadastro : frmBaseCadastro
    {
        public frmFuncionarioCadastro()
        {
            InitializeComponent();
        }

        private void frmFuncionarioCadastro_Load(object sender, EventArgs e)
        {
            Departamento departamento = new Departamento();
            DepartamentoService departamentoService = new DepartamentoService();
        }
    }
}

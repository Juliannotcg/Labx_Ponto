using LabxPonto_Dao.Data.Context;
using LabxPonto_View.Views.Base;
using LabxPonto_View.Views.Funcionarios;
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

namespace LabxPonto_View.Views
{
    public partial class frmRelatorios : frmBaseCadastro
    {
        private AppDataContext context; 
        public frmRelatorios(AppDataContext con)
        {
            context = con;
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtCPF_Click(object sender, EventArgs e)
        {

        }

        public bool Validar()
        {
            if (String.IsNullOrEmpty(txtCPF.Text))
                errorProviderRlt.SetError(txtCPF, "Informe o número do CPF.");

            if (dtDataIni.Value < dtDataFim.Value)
                errorProviderRlt.SetError(dtDataFim, "A data inicial não pode ser menor que a data inicial.");

            return ((errorProviderRlt.GetError(txtCPF) == "") &&
                (errorProviderRlt.GetError(dtDataFim) == ""));
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        public void Confirmar()
        {
            if (Validar())
            {
                frmRltFuncionario janela = new frmRltFuncionario(context, txtCPF.Text);
                janela.Show();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

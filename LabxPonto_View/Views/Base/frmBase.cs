using MetroFramework.Forms;

namespace LabxPonto_View.Views.Base
{
    public partial class frmBase : MetroForm
    {
        public frmBase()
        {
            InitializeComponent();
        }

        public virtual void btNovo_Click(object sender, System.EventArgs e)
        {

        }

        public virtual void btAlterar_Click(object sender, System.EventArgs e)
        {

        }

        public virtual void btExcluir_Click(object sender, System.EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }
    }
}

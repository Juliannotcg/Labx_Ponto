using LabxPonto_Dao.Injection;
using LabxPonto_Dao.Service;
using LabxPonto_View.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace LabxPonto_View
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());


            // Configure Dependency Injection
            var container = new UnityContainer();
            DependencyResolver.Resolve(container);

            container.Resolve<FuncaoService>();
            container.Resolve<FuncionarioService>();
            container.Resolve<DepartamentoService>();
            container.Resolve<EmpresaService>();

        }
    }
}

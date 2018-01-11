using LabxPonto_Dao.Data.Context;
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
            AppDataContext contexto = new AppDataContext();
            //Application.Run(new frmLogin(contexto));
            frmLogin login = new frmLogin(contexto);
            
            if(login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmMain(contexto));
            }

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

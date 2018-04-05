﻿using LabxPonto_Dao.Data.Context;
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

            //frmMain main = new frmMain(contexto);
            //Application.Run(main);

            //frmLogin login = new frmLogin(contexto);

            //using (var mutex = new System.Threading.Mutex(true, "A403A6EB-6472-4B42-B5C1-C0E06F9F25B3"))
            //{
            //    var jaEstaRodando = !mutex.WaitOne(0, true);
            //    if (jaEstaRodando)
            //        return;

            //    if (login.ShowDialog() == DialogResult.OK)
            //    {
                    frmMain main = new frmMain(contexto);
                    //main.Usuario = login.Usuario;
                    Application.Run(main);
            //    }

            //    mutex.ReleaseMutex();
            //}

            // Configure Dependency Injection
            var container = new UnityContainer();
            DependencyResolver.Resolve(container);

            container.Resolve<FuncaoService>();
            container.Resolve<FuncionarioService>();
            container.Resolve<DepartamentoService>();
            container.Resolve<EmpresaService>();
            container.Resolve<HorarioService>();
        }
    }
}

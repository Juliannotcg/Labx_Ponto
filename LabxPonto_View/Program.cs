using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Injection;
using LabxPonto_Dao.Service;
using LabxPonto_View.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabxPonto_Dao.Model;
using Unity;
using System.IO;
using Newtonsoft.Json;
using LabxPonto_View.ConfiguracaoServidor;

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


            LendoArquivoConfiguracao();

            AppDataContext contexto = new AppDataContext();
            contexto.Database.CreateIfNotExists();
            CriandoUsuarioSuporte(contexto);

            frmLogin login = new frmLogin(contexto);

            using (var mutex = new System.Threading.Mutex(true, "A403A6EB-6472-4B42-B5C1-C0E06F9F25B3"))
            {
                var jaEstaRodando = !mutex.WaitOne(0, true);
                if (jaEstaRodando)
                    return;

                if (login.ShowDialog() == DialogResult.OK)
                {
                    frmMain main = new frmMain(contexto);
                    main.Usuario = login.Usuario;
                    Application.Run(main);
                }

                mutex.ReleaseMutex();
            }

            // Configure Dependency Injection
            DependencyInjection();
        }

        private static void DependencyInjection()
        {
            var container = new UnityContainer();
            DependencyResolver.Resolve(container);

            container.Resolve<FuncaoService>();
            container.Resolve<FuncionarioService>();
            container.Resolve<DepartamentoService>();
            container.Resolve<EmpresaService>();
            container.Resolve<HorarioService>();
        }

        static void CriandoUsuarioSuporte(AppDataContext contexto)
        {
            var result = contexto.Usuarios.FirstOrDefault(x => x.Login == "SUPORTE");

            if (result != null) return;
            var newUsuario = new Usuario()
            {
                Login = "SUPORTE",
                Perfil = "Suporte",
                Senha = "YWRtaW4="
            };
            contexto.Usuarios.Add(newUsuario);
            contexto.SaveChanges();
        }

        private static void LendoArquivoConfiguracao()
        {
            ConfiguracaoBanco dadosConfiguracao = new ConfiguracaoBanco();
            var localizacao = Path.Combine(Directory.GetCurrentDirectory(), @"ConfiguracaoBanco.json");

            //var fi = new System.IO.FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //var pastaExe = fi.Directory.FullName;
            //var caminhoArquivo = System.IO.Path.Combine(pastaExe, @"C:\Users\juliano.P21\Documents\ePonto\Labx_Ponto\LabxPonto_View\ConfiguracaoBanco.json");

            using (StreamReader r = new StreamReader(@"C:\Users\juliano.P21\Documents\ePonto\Labx_Ponto\LabxPonto_View\ConfiguracaoBanco.json"))
            {
                string json = r.ReadToEnd();
                ConfiguracaoBanco ro = JsonConvert.DeserializeObject<ConfiguracaoBanco>(json);
                if (ro.BancoGerado)
                    return;
            }
            PrimeiroAcesso();
        }

        private static void PrimeiroAcesso()
        {
            frmConfiguracaoInicial configuracaoInicial = new frmConfiguracaoInicial();
            configuracaoInicial.ShowDialog();
        }
    }
}

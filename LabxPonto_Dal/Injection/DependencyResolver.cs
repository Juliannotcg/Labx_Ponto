using LabxPonto_Dao.Data.Context;
using LabxPonto_Dao.Service;
using Unity;
using Unity.Lifetime;

namespace LabxPonto_Dao.Injection
{
    public class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {
            //Context
            container.RegisterType<AppDataContext, AppDataContext>(new HierarchicalLifetimeManager());

            //Funcionario
            container.RegisterType<FuncionarioService, FuncionarioService>(new HierarchicalLifetimeManager());

            //Function
            container.RegisterType<FuncaoService, FuncaoService>(new HierarchicalLifetimeManager());

            //Department
            container.RegisterType<DepartamentoService, DepartamentoService>(new HierarchicalLifetimeManager());

            //Empresa
            container.RegisterType<EmpresaService, EmpresaService>(new HierarchicalLifetimeManager());

        }
    }
}

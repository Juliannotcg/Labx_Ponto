using LabxPonto_Dao.Data.Mapa;
using LabxPonto_Dao.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LabxPonto_Dao.Data.Context
{
    public class AppDataContext: DbContext
    {
        public AppDataContext() : base("ConexaoPonto")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Funcao> Funcoes { get; set; }
        public DbSet<Funcionario> Funcionarios{ get; set; }
        public DbSet<HorarioExpediente> HorariosExpediente { get; set; }
        public DbSet<Usuario> Usuarios{ get; set; }

        public DbSet<Imagem> Imagens{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
           .Where(p => p.Name == p.ReflectedType.Name + "Id")
           .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
            .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new DepartamentoMap());
            modelBuilder.Configurations.Add(new EmpresaMap());
            modelBuilder.Configurations.Add(new EnderecoMap());
            modelBuilder.Configurations.Add(new FuncaoMap());
            modelBuilder.Configurations.Add(new FuncionarioMap());
            modelBuilder.Configurations.Add(new HorarioExpedienteMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new ImagemMap());

        }
    }
}

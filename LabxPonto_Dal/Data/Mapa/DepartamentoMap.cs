using LabxPonto_Dao.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LabxPonto_Dao.Data.Mapa
{
    public class DepartamentoMap:EntityTypeConfiguration<Department>
    {
        public DepartamentoMap()
        {
            ToTable("DepDepartamento");

            Property(c => c.Id)
              .HasColumnOrder(1)
              .HasColumnName("DepId")
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.NameDepartment)
                .HasColumnName("DepNomeDepartamento");

            Property(c => c.Description)
                .HasColumnName("DepDescricao");
        }
    }
}

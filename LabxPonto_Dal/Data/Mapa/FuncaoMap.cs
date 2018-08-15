using LabxPonto_Dao.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LabxPonto_Dao.Data.Mapa
{
    public class FuncaoMap:EntityTypeConfiguration<Funcao>
    {
        public FuncaoMap()
        {
            ToTable("FncFuncao");

            Property(c => c.Id)
              .HasColumnOrder(1)
              .HasColumnName("FncId")
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.NomeFuncao)
                .HasColumnName("FncNome");

            Property(c => c.Descricao)
                .HasColumnName("FncDescricao");

            HasOptional(o => o.Departamento)
               .WithMany()
               .Map(m => m.MapKey("Fnc_DepId"));

        }
    }
}

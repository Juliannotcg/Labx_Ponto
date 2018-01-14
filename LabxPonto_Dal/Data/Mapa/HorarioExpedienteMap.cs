using LabxPonto_Dao.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LabxPonto_Dao.Data.Mapa
{
    public class HorarioExpedienteMap: EntityTypeConfiguration<HorarioExpediente>
    {
        public HorarioExpedienteMap()
        {
            ToTable("HorHorarioExpediente");

            Property(c => c.Id)
              .HasColumnOrder(1)
              .HasColumnName("HorId")
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Data)
                .HasColumnName("HorData");


            Property(c => c.Entrada)
                .HasColumnName("HorEntrada");

            Property(c => c.Saida)
                .HasColumnName("HorSaida");

            HasOptional(o => o.Funcionario)
               .WithMany()
               .Map(m => m.MapKey("Hor_FunId"));
        }
    }
}

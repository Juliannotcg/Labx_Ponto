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
                .HasColumnName("HorDataExpediente");

            Property(c => c.Descricao)
                .HasColumnName("HorDescricao");

            Property(c => c.InicioTurno)
                .HasColumnName("HorInicioTurno");

            Property(c => c.FimTurno)
                .HasColumnName("HorFimTurno");

            Property(c => c.InicioAlmoco)
                .HasColumnName("HorInicioAlmoco");

            Property(c => c.FimAlmoco)
                .HasColumnName("HorFimAlmoco");

            Property(c => c.InicioAbono)
                .HasColumnName("HorInicioAbono");

            Property(c => c.FimAbono)
                .HasColumnName("HorFimAbono");

            Property(c => c.JustificativaAbono)
                .HasColumnName("HorJustificativaAbono");

            HasOptional(o => o.Funcionario)
               .WithMany()
               .Map(m => m.MapKey("Hor_FunId"));
        }
    }
}

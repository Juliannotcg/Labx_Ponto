using LabxPonto_Dao.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LabxPonto_Dao.Data.Mapa
{
    public class ContratoMap: EntityTypeConfiguration<Contrato>
    {
        public ContratoMap()
        {
            ToTable("ConContrato");

            Property(c => c.Id)
              .HasColumnOrder(1)
              .HasColumnName("ConId")
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.NumeroFolha)
                .HasColumnName("ConNumeroFolha");

            Property(c => c.DataAdmissao)
                .HasColumnName("ConDataAdmissao")
                .HasColumnType("datetime2");

            Property(c => c.DataRecisao)
                .HasColumnName("ConDataRecisao")
                 .HasColumnType("datetime2");

            Property(c => c.MotivoRecisao)
                .HasColumnName("ConMotivoRecisao");
        }
    }
}

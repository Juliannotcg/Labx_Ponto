using LabxPonto_Dao.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LabxPonto_Dao.Data.Mapa
{
    public class ImagemMap: EntityTypeConfiguration<Imagem>
    {
        public ImagemMap()
        {
            ToTable("ImaImagem");

            Property(c => c.Id)
              .HasColumnOrder(1)
              .HasColumnName("ImaId")
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Arquivo)
                .HasColumnName("ImaArquivo")
                .HasColumnType("varbinary(MAX)");
        }
    }
}

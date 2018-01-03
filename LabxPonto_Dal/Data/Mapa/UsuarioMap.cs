using LabxPonto_Dao.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LabxPonto_Dao.Data.Mapa
{
    public class UsuarioMap:EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("UsuUsuario");

            Property(c => c.Id)
              .HasColumnOrder(1)
              .HasColumnName("UsuId")
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Login)
                .HasColumnName("UsuLogin");

            Property(c => c.Senha)
                .HasColumnName("UsuSenha");
        }
    }
}

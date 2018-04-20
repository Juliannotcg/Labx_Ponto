using LabxPonto_Dao.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LabxPonto_Dao.Data.Mapa
{
    public class EnderecoMap: EntityTypeConfiguration<Address>
    {
        public EnderecoMap()
        {
            ToTable("EndEndereco");

            Property(c => c.Id)
              .HasColumnOrder(1)
              .HasColumnName("EndId")
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Logradouro)
                .HasColumnName("EndLogradouro");

            Property(c => c.Street)
                .HasColumnName("EndRua");

            Property(c => c.Estate)
                .HasColumnName("EndEstado");

            Property(c => c.Pais)
                .HasColumnName("EmpPais");

            Property(c => c.City)
                .HasColumnName("EndCidade");

            Property(c => c.Neighborhood)
                .HasColumnName("EndBairro");

            Property(c => c.Complement)
                .HasColumnName("EndComplemento");

            Property(c => c.Number)
                .HasColumnName("EndNumero");

            Property(c => c.Cep)
             .HasColumnName("EndCep");

        }
    }
}

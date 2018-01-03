using LabxPonto_View.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LabxPonto_Dao.Data.Mapa
{
    public class EnderecoMap: EntityTypeConfiguration<Endereco>
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

            Property(c => c.Rua)
                .HasColumnName("EndRua");

            Property(c => c.Estado)
                .HasColumnName("EndEstado");

            Property(c => c.Cidade)
                .HasColumnName("EndCidade");

            Property(c => c.Bairro)
                .HasColumnName("EndBairro");

            Property(c => c.Complemento)
                .HasColumnName("EndComplemento");

            Property(c => c.Numero)
                .HasColumnName("EndNumero");

            Property(c => c.Cep)
             .HasColumnName("EndCep");

        }
    }
}

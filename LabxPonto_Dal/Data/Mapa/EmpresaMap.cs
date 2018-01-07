using LabxPonto_Dao.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LabxPonto_Dao.Data.Mapa
{
    public class EmpresaMap : EntityTypeConfiguration<Empresa>
    {
        public EmpresaMap()
        {
            ToTable("EmpEmpresa");

            Property(c => c.Id)
              .HasColumnOrder(1)
              .HasColumnName("EmpId")
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.NomeFantasia)
                .HasColumnName("EmpNomeFantasia");

            Property(c => c.RazaoSocial)
                .HasColumnName("EmpRazaoSocial");

            Property(c => c.CNPJ)
                .HasColumnName("EmpCNPJ");

            Property(c => c.NomeResponsavel)
                .HasColumnName("EmpNomeResponsavel");

            Property(c => c.EmailResponsavel)
                .HasColumnName("EmpEmailResponsavel");

            Property(c => c.CEI)
                .HasColumnName("EmpCEI");

            Property(c => c.CargoResponsavel)
                .HasColumnName("EmpCargoResponsavel");

            Property(c => c.NumeroFolha)
                .HasColumnName("EmpNumeroFolha");

            Property(c => c.Inscricao)
                .HasColumnName("EmpInscricao");

            HasOptional(o => o.Endereco)
               .WithMany()
               .Map(m => m.MapKey("Emp_EndId"));

            HasOptional(o => o.Imagem)
               .WithMany()
               .Map(m => m.MapKey("Emp_ImaId"));
        }
    }
}

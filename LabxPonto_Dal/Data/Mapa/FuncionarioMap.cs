using LabxPonto_Dao.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LabxPonto_Dao.Data.Mapa
{
    public class FuncionarioMap : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioMap()
        {
            ToTable("FunFuncionario");

            Property(c => c.Id)
              .HasColumnOrder(1)
              .HasColumnName("FunId")
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Nome)
                .HasColumnName("FunNome");

            Property(c => c.SobreNome)
                .HasColumnName("FunSobrenome");

            Property(c => c.RG)
                .HasColumnName("FunRG");

            Property(c => c.CPF)
                .HasColumnName("FunCPF");

            Property(c => c.Digital)
                .HasColumnName("FunDigital");

            Property(c => c.EstadoCivil)
                .HasColumnName("FunEstadoCivil");

            Property(c => c.Telefone)
                .HasColumnName("FunTelefone");

            Property(c => c.NomePai)
                .HasColumnName("FunNomePai");

            Property(c => c.NomeMae)
                .HasColumnName("FunNomeMae");

            Property(c => c.LocalTrabalho)
                .HasColumnName("FunLocalTrabalho");

            Property(c => c.DataNascimento)
                .HasColumnName("FunDataNascimento")
                .HasColumnType("datetime2");

            HasOptional(o => o.Endereco)
               .WithMany()
               .Map(m => m.MapKey("Fun_EndId"));

            HasOptional(o => o.Funcao)
               .WithMany()
               .Map(m => m.MapKey("Fun_FncId"));

            HasOptional(o => o.Empresa)
               .WithMany()
               .Map(m => m.MapKey("Fun_EmpId"));

            HasOptional(o => o.Imagem)
               .WithMany()
               .Map(m => m.MapKey("Fun_ImaId"));

            Property(r => r.DataAdmissao)
             .HasColumnName("FunDataAdmissao")
               .HasColumnType("datetime2");

            Property(r => r.DataRecisao)
            .HasColumnName("FunDataRecisao")
            .HasColumnType("datetime2");

            Property(r => r.MotivoRecisao)
            .HasColumnName("FunMotivoRecisao");

            Property(r => r.NumeroFolha)
            .HasColumnName("FunNumeroFolha");
        }
    }
}

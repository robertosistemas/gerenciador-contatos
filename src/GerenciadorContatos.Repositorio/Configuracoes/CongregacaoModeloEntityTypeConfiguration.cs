using GerenciadorContatos.Modelos;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GerenciadorContatos.Repositorio.Configuracoes
{
    public class CongregacaoModeloEntityTypeConfiguration : EntityTypeConfiguration<CongregacaoModelo>
    {
        public CongregacaoModeloEntityTypeConfiguration()
        {
            ToTable("Congregacao");

            HasKey(p => p.Id);

            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.MunicipioId).IsRequired();
            Property(p => p.Numero).IsRequired();
            Property(p => p.Nome).HasMaxLength(100).IsRequired();

            HasRequired(f => f.Municipio)
                .WithMany(f => f.Congregacoes)
                .HasForeignKey(f => f.MunicipioId);

        }
    }
}

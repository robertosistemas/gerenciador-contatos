using GerenciadorContatos.Modelos;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GerenciadorContatos.Repositorio.Configuracoes
{
    public class PublicadorModeloEntityTypeConfiguration : EntityTypeConfiguration<PublicadorModelo>
    {
        public PublicadorModeloEntityTypeConfiguration()
        {
            ToTable("Publicador");

            HasKey(p => p.Id);

            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.CongregacaoId).IsRequired();
            Property(p => p.Nome).HasMaxLength(100).IsRequired();

            HasRequired(f => f.Congregacao)
                .WithMany(f => f.Publicadores)
                .HasForeignKey(f => f.CongregacaoId);

        }
    }
}

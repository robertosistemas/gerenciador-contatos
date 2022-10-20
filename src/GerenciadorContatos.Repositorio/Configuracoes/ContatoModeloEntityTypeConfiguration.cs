using GerenciadorContatos.Modelos;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GerenciadorContatos.Repositorio.Configuracoes
{
    public class ContatoModeloEntityTypeConfiguration : EntityTypeConfiguration<ContatoModelo>
    {
        public ContatoModeloEntityTypeConfiguration()
        {
            ToTable("Contato");

            HasKey(p => p.Id);

            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.OperadoraId).IsRequired();
            Property(p => p.CartaoId).IsRequired();
            Property(p => p.Numero).HasMaxLength(20).IsRequired();
            Property(p => p.PermiteLigar).IsRequired();
            Property(p => p.Nome).HasMaxLength(100);
            Property(p => p.Observacao).HasMaxLength(500);

            HasRequired(f => f.Operadora)
                .WithMany(f => f.Contatos)
                .HasForeignKey(f => f.OperadoraId);

            HasRequired(f => f.Operadora)
                .WithMany(f => f.Contatos)
                .HasForeignKey(f => f.OperadoraId);

        }
    }
}

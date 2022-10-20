using GerenciadorContatos.Modelos;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GerenciadorContatos.Repositorio.Configuracoes
{
    public class ContatoHistoricoModeloEntityTypeConfiguration : EntityTypeConfiguration<ContatoHistoricoModelo>
    {
        public ContatoHistoricoModeloEntityTypeConfiguration()
        {
            ToTable("ContatoHistorico");

            HasKey(p => p.Id);

            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.ContatoId).IsRequired();
            Property(p => p.PublicadorId).IsRequired();
            Property(p => p.Data).IsRequired();
            Property(p => p.Observacao).HasMaxLength(500);

            HasRequired(f => f.Contato)
                .WithMany(f => f.ContatosHistoricos)
                .HasForeignKey(f => f.ContatoId);

            HasRequired(f => f.Publicador)
                .WithMany(f => f.ContatosHistoricos)
                .HasForeignKey(f => f.PublicadorId);

        }
    }
}

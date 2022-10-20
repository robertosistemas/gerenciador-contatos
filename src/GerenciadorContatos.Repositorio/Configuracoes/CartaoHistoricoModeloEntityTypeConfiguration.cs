using GerenciadorContatos.Modelos;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GerenciadorContatos.Repositorio.Configuracoes
{
    public class CartaoHistoricoModeloEntityTypeConfiguration : EntityTypeConfiguration<CartaoHistoricoModelo>
    {
        public CartaoHistoricoModeloEntityTypeConfiguration()
        {
            ToTable("CartaoHistorico");

            HasKey(p => p.Id);

            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.CartaoId).IsRequired();
            Property(p => p.PublicadorId).IsRequired();
            Property(p => p.DataInicio).IsRequired();
            Property(p => p.DataFim);
            Property(p => p.Observacao).HasMaxLength(500);

            HasRequired(f => f.Cartao)
                .WithMany(f => f.CartoesHistoricos)
                .HasForeignKey(f => f.CartaoId);

            HasRequired(f => f.Publicador)
                .WithMany(f => f.CartoesHistoricos)
                .HasForeignKey(f => f.CartaoId);

        }
    }
}

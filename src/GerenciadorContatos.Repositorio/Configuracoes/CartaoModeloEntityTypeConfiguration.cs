using GerenciadorContatos.Modelos;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GerenciadorContatos.Repositorio.Configuracoes
{
    public class CartaoModeloEntityTypeConfiguration : EntityTypeConfiguration<CartaoModelo>
    {
        public CartaoModeloEntityTypeConfiguration()
        {
            ToTable("Cartao");

            HasKey(p => p.Id);

            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.CongregacaoId).IsRequired();
            Property(p => p.OperadoraId).IsRequired();
            Property(p => p.Numero).HasMaxLength(20).IsRequired();
            Property(p => p.FaixaNumerica).HasMaxLength(35).IsRequired();
            Property(p => p.Disponivel).IsRequired();
            Property(p => p.PublicadorId);
            Property(p => p.DataInicio);
            Property(p => p.DataFim);
            Property(p => p.Observacao).HasMaxLength(500);

            HasRequired(f => f.Operadora)
                .WithMany(f => f.Cartoes)
                .HasForeignKey(f => f.OperadoraId);

            HasRequired(f => f.Congregacao)
                .WithMany(f => f.Cartoes)
                .HasForeignKey(f => f.CongregacaoId);

            HasOptional(f => f.Publicador)
                .WithMany(f => f.Cartoes)
                .HasForeignKey(f => f.PublicadorId);
        }
    }
}

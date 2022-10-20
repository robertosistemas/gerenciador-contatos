using GerenciadorContatos.Modelos;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GerenciadorContatos.Repositorio.Configuracoes
{
    public class SequenciaNumericaModeloEntityTypeConfiguration : EntityTypeConfiguration<SequenciaNumericaModelo>
    {
        public SequenciaNumericaModeloEntityTypeConfiguration()
        {
            ToTable("SequenciaNumerica");

            HasKey(p => p.Id);

            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.CongregacaoId).IsRequired();
            Property(p => p.OperadoraId).IsRequired();
            Property(p => p.CodigoArea).HasMaxLength(3).IsRequired();
            Property(p => p.PreFixo).HasMaxLength(5).IsRequired();
            Property(p => p.Inicio).IsRequired();
            Property(p => p.Fim).IsRequired();
            Property(p => p.QuantidadeTelefonesCartao).IsRequired();

            HasRequired(f => f.Congregacao)
                .WithMany(f => f.SequenciasNumericas)
                .HasForeignKey(f => f.CongregacaoId);

            HasRequired(f => f.Operadora)
                .WithMany(f => f.SequenciasNumericas)
                .HasForeignKey(f => f.OperadoraId);
        }
    }
}

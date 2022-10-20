using GerenciadorContatos.Modelos;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GerenciadorContatos.Repositorio.Configuracoes
{
    public class OperadoraModeloEntityTypeConfiguration : EntityTypeConfiguration<OperadoraModelo>
    {
        public OperadoraModeloEntityTypeConfiguration()
        {
            ToTable("Operadora");

            HasKey(s => s.Id);

            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Codigo).IsRequired();
            Property(p => p.Nome).HasMaxLength(100).IsRequired();

            //HasMany<CartaoModelo>(f => f.Cartoes)
            //    .WithRequired(f => f.Operadora)
            //    .HasForeignKey(f => f.OperadoraId);

        }
    }
}

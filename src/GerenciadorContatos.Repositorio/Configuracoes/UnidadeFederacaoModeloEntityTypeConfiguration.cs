using GerenciadorContatos.Modelos;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GerenciadorContatos.Repositorio.Configuracoes
{
    public class UnidadeFederacaoModeloEntityTypeConfiguration : EntityTypeConfiguration<UnidadeFederacaoModelo>
    {
        public UnidadeFederacaoModeloEntityTypeConfiguration()
        {
            ToTable("UnidadeFederacao");

            HasKey(p => p.Id);

            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Sigla).HasMaxLength(2).IsRequired();
            Property(p => p.Nome).HasMaxLength(100).IsRequired();

        }
    }
}

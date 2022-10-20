using GerenciadorContatos.Modelos;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GerenciadorContatos.Repositorio.Configuracoes
{
    public class MunicipioModeloEntityTypeConfiguration : EntityTypeConfiguration<MunicipioModelo>
    {
        public MunicipioModeloEntityTypeConfiguration()
        {
            ToTable("Municipio");

            HasKey(p => p.Id);

            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.UnidadeFederacaoId).IsRequired();
            Property(p => p.Nome).HasMaxLength(100).IsRequired();

            HasRequired(f => f.UnidadeFederacao)
                .WithMany(f => f.Municipios)
                .HasForeignKey(f => f.UnidadeFederacaoId);

        }
    }
}

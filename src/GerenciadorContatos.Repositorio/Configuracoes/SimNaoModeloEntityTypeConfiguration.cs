using GerenciadorContatos.Modelos;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GerenciadorContatos.Repositorio.Configuracoes
{
    public class SimNaoModeloEntityTypeConfiguration : EntityTypeConfiguration<SimNaoModelo>
    {
        public SimNaoModeloEntityTypeConfiguration()
        {
            ToTable("SimNao");

            HasKey(p => p.Id);

            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Texto).HasMaxLength(10).IsRequired();
            Property(p => p.Valor);
        }
    }
}

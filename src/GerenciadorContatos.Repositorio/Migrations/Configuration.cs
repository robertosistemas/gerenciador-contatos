using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;

namespace GerenciadorContatos.Repositorio.Migrations
{
    public  class Configuration : DbMigrationsConfiguration<GerenciadorContatos.Repositorio.GerenciadorContatoDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }

        protected override void Seed(GerenciadorContatos.Repositorio.GerenciadorContatoDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            //context.SimsNaos.AddOrUpdate(new Modelos.SimNaoModelo { Id = 1, Texto = "(Todos)", Valor = null });
            //context.SimsNaos.AddOrUpdate(new Modelos.SimNaoModelo { Id = 2, Texto = "Sim", Valor = true });
            //context.SimsNaos.AddOrUpdate(new Modelos.SimNaoModelo { Id = 3, Texto = "Não", Valor = false });
        }
    }
}

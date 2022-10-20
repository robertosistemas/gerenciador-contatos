using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;
using GerenciadorContatos.Repositorio.Configuracoes;
using System;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite;
using System.Linq;

namespace GerenciadorContatos.Repositorio
{
    public class GerenciadorContatoDbContext : DbContext
    {
        public DbSet<CartaoModelo> Cartoes { get; set; }
        public DbSet<CartaoHistoricoModelo> CartoesHistoricos { get; set; }
        public DbSet<CongregacaoModelo> Congregacoes { get; set; }
        public DbSet<ContatoModelo> Contatos { get; set; }
        public DbSet<ContatoHistoricoModelo> ContatosHistoricos { get; set; }
        public DbSet<MunicipioModelo> Municipios { get; set; }
        public DbSet<OperadoraModelo> Operadoras { get; set; }
        public DbSet<PublicadorModelo> Publicadores { get; set; }
        public DbSet<UnidadeFederacaoModelo> UnidadesFederacao { get; set; }
        public DbSet<SequenciaNumericaModelo> SequenciasNumericas { get; set; }
        public DbSet<SimNaoModelo> SimsNaos { get; set; }

        public GerenciadorContatoDbContext() : base(new SQLiteConnection(Configuracao.StringConexao), true)
        {
            Database.Log = GravaLog;
        }

        //public GerenciadorContatoDbContext() : base("name=GerenciadorContatoDbContext")
        //{
        //    Database.Log = GravaLog;
        //}

        //public GerenciadorContatoDbContext() : base(Configuracao.StringConexao)
        //{
        //    Database.Log = GravaLog;
        //}

        public GerenciadorContatoDbContext(DbConnection connection) : base(connection, true)
        {
            Database.Log = GravaLog;
        }

        public GerenciadorContatoDbContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
        {
            Database.Log = GravaLog;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CartaoModeloEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new CartaoHistoricoModeloEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new CongregacaoModeloEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new ContatoModeloEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new ContatoHistoricoModeloEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new MunicipioModeloEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new OperadoraModeloEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new PublicadorModeloEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new SequenciaNumericaModeloEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new UnidadeFederacaoModeloEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new SimNaoModeloEntityTypeConfiguration());

            //if (Configuracao.StringConexao.Contains("GerenciadorContatosTestes.db"))
            //{
            //    Database.SetInitializer(new MigrateDatabaseToLatestVersion<GerenciadorContatoDbContext, Configuration>(true));
            //}
        }

        public void RejeitarAlteracoes()
        {

            RejectScalarChanges();
            RejectNavigationChanges();
        }

        private void RejectScalarChanges()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified;
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                }
            }
        }

        private void RejectNavigationChanges()
        {
            var objectContext = ((IObjectContextAdapter)this).ObjectContext;
            var deletedRelationships = objectContext.ObjectStateManager.GetObjectStateEntries(EntityState.Deleted).Where(e => e.IsRelationship && !RelationshipContainsKeyEntry(e));
            var addedRelationships = objectContext.ObjectStateManager.GetObjectStateEntries(EntityState.Added).Where(e => e.IsRelationship);

            foreach (var relationship in addedRelationships)
                relationship.Delete();

            foreach (var relationship in deletedRelationships)
                relationship.ChangeState(EntityState.Unchanged);
        }

        private bool RelationshipContainsKeyEntry(System.Data.Entity.Core.Objects.ObjectStateEntry stateEntry)
        {
            var objectContext = ((IObjectContextAdapter)this).ObjectContext;
            var keys = new[] { stateEntry.OriginalValues[0], stateEntry.OriginalValues[1] };
            return keys.Any(key => objectContext.ObjectStateManager.GetObjectStateEntry(key).Entity == null);
        }

        public static void GravaLog(string sql)
        {
            Console.WriteLine(sql);
        }

    }

    ///// <seealso cref="https://msdn.microsoft.com/en-us/data/jj680699"/>
    ///// <seealso cref="https://www.codeproject.com/Articles/1158937/Using-SQLite-database-with-Csharp-Net-and-Entity-F"/>
    //public class SQLiteConfiguration : DbConfiguration
    //{
    //    public SQLiteConfiguration()
    //    {
    //        SetProviderFactory("System.Data.SQLite", SQLiteFactory.Instance);
    //        SetProviderFactory("System.Data.SQLite.EF6", SQLiteProviderFactory.Instance);
    //        SetProviderServices("System.Data.SQLite", (DbProviderServices)SQLiteProviderFactory.Instance.GetService(typeof(DbProviderServices)));
    //    }
    //}

    //internal sealed class Configuration : DbMigrationsConfiguration<GerenciadorContatos.Repositorio.GerenciadorContatoDbContext>
    //{
    //    public Configuration()
    //    {
    //        AutomaticMigrationsEnabled = true;
    //        AutomaticMigrationDataLossAllowed = true;
    //        SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
    //    }

    //    protected override void Seed(GerenciadorContatos.Repositorio.GerenciadorContatoDbContext context)
    //    {
    //        //  This method will be called after migrating to the latest version.

    //        //  You can use the DbSet<T>.AddOrUpdate() helper extension method
    //        //  to avoid creating duplicate seed data.
    //    }
    //}

}

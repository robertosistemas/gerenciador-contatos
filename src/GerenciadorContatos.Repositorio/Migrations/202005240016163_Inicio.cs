namespace GerenciadorContatos.Repositorio.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cartao",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    CongregacaoId = c.Int(nullable: false),
                    OperadoraId = c.Int(nullable: false),
                    Numero = c.String(nullable: false, maxLength: 20),
                    FaixaNumerica = c.String(nullable: false, maxLength: 35),
                    Disponivel = c.Boolean(nullable: false),
                    PublicadorId = c.Int(),
                    DataInicio = c.DateTime(),
                    DataFim = c.DateTime(),
                    Observacao = c.String(maxLength: 500),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Congregacao", t => t.CongregacaoId, cascadeDelete: true)
                .ForeignKey("dbo.Operadora", t => t.OperadoraId, cascadeDelete: true)
                .ForeignKey("dbo.Publicador", t => t.PublicadorId)
                .Index(t => t.CongregacaoId)
                .Index(t => t.OperadoraId)
                .Index(t => t.PublicadorId);

            CreateTable(
                "dbo.CartaoHistorico",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    CartaoId = c.Int(nullable: false),
                    PublicadorId = c.Int(nullable: false),
                    DataInicio = c.DateTime(nullable: false),
                    DataFim = c.DateTime(),
                    Observacao = c.String(maxLength: 500),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cartao", t => t.CartaoId, cascadeDelete: true)
                .ForeignKey("dbo.Publicador", t => t.CartaoId, cascadeDelete: true)
                .Index(t => t.CartaoId);

            CreateTable(
                "dbo.Publicador",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    CongregacaoId = c.Int(nullable: false),
                    Nome = c.String(nullable: false, maxLength: 100),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Congregacao", t => t.CongregacaoId, cascadeDelete: true)
                .Index(t => t.CongregacaoId);

            CreateTable(
                "dbo.Congregacao",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    MunicipioId = c.Int(nullable: false),
                    Numero = c.Int(nullable: false),
                    Nome = c.String(nullable: false, maxLength: 100),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Municipio", t => t.MunicipioId, cascadeDelete: true)
                .Index(t => t.MunicipioId);

            CreateTable(
                "dbo.Municipio",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    UnidadeFederacaoId = c.Int(nullable: false),
                    Nome = c.String(nullable: false, maxLength: 100),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UnidadeFederacao", t => t.UnidadeFederacaoId, cascadeDelete: true)
                .Index(t => t.UnidadeFederacaoId);

            CreateTable(
                "dbo.UnidadeFederacao",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Sigla = c.String(nullable: false, maxLength: 2),
                    Nome = c.String(nullable: false, maxLength: 100),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.SequenciaNumerica",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    CongregacaoId = c.Int(nullable: false),
                    OperadoraId = c.Int(nullable: false),
                    CodigoArea = c.String(nullable: false, maxLength: 3),
                    PreFixo = c.String(nullable: false, maxLength: 5),
                    Inicio = c.Int(nullable: false),
                    Fim = c.Int(nullable: false),
                    QuantidadeTelefonesCartao = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Congregacao", t => t.CongregacaoId, cascadeDelete: true)
                .ForeignKey("dbo.Operadora", t => t.OperadoraId, cascadeDelete: true)
                .Index(t => t.CongregacaoId)
                .Index(t => t.OperadoraId);

            CreateTable(
                "dbo.Operadora",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Codigo = c.Int(nullable: false),
                    Nome = c.String(nullable: false, maxLength: 100),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Contato",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    OperadoraId = c.Int(nullable: false),
                    CartaoId = c.Int(nullable: false),
                    Numero = c.String(nullable: false, maxLength: 20),
                    PermiteLigar = c.Boolean(nullable: false),
                    Nome = c.String(maxLength: 100),
                    Observacao = c.String(maxLength: 500),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cartao", t => t.CartaoId, cascadeDelete: true)
                .ForeignKey("dbo.Operadora", t => t.OperadoraId, cascadeDelete: true)
                .Index(t => t.OperadoraId)
                .Index(t => t.CartaoId);

            CreateTable(
                "dbo.ContatoHistorico",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    ContatoId = c.Int(nullable: false),
                    PublicadorId = c.Int(nullable: false),
                    Data = c.DateTime(nullable: false),
                    Observacao = c.String(maxLength: 500),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contato", t => t.ContatoId, cascadeDelete: true)
                .ForeignKey("dbo.Publicador", t => t.PublicadorId, cascadeDelete: true)
                .Index(t => t.ContatoId)
                .Index(t => t.PublicadorId);

            CreateTable(
                "dbo.SimNao",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Texto = c.String(nullable: false, maxLength: 10),
                    Valor = c.Boolean(),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Cartao", "PublicadorId", "dbo.Publicador");
            DropForeignKey("dbo.Cartao", "OperadoraId", "dbo.Operadora");
            DropForeignKey("dbo.Cartao", "CongregacaoId", "dbo.Congregacao");
            DropForeignKey("dbo.CartaoHistorico", "CartaoId", "dbo.Publicador");
            DropForeignKey("dbo.Publicador", "CongregacaoId", "dbo.Congregacao");
            DropForeignKey("dbo.SequenciaNumerica", "OperadoraId", "dbo.Operadora");
            DropForeignKey("dbo.Contato", "OperadoraId", "dbo.Operadora");
            DropForeignKey("dbo.ContatoHistorico", "PublicadorId", "dbo.Publicador");
            DropForeignKey("dbo.ContatoHistorico", "ContatoId", "dbo.Contato");
            DropForeignKey("dbo.Contato", "CartaoId", "dbo.Cartao");
            DropForeignKey("dbo.SequenciaNumerica", "CongregacaoId", "dbo.Congregacao");
            DropForeignKey("dbo.Congregacao", "MunicipioId", "dbo.Municipio");
            DropForeignKey("dbo.Municipio", "UnidadeFederacaoId", "dbo.UnidadeFederacao");
            DropForeignKey("dbo.CartaoHistorico", "CartaoId", "dbo.Cartao");
            DropIndex("dbo.ContatoHistorico", new[] { "PublicadorId" });
            DropIndex("dbo.ContatoHistorico", new[] { "ContatoId" });
            DropIndex("dbo.Contato", new[] { "CartaoId" });
            DropIndex("dbo.Contato", new[] { "OperadoraId" });
            DropIndex("dbo.SequenciaNumerica", new[] { "OperadoraId" });
            DropIndex("dbo.SequenciaNumerica", new[] { "CongregacaoId" });
            DropIndex("dbo.Municipio", new[] { "UnidadeFederacaoId" });
            DropIndex("dbo.Congregacao", new[] { "MunicipioId" });
            DropIndex("dbo.Publicador", new[] { "CongregacaoId" });
            DropIndex("dbo.CartaoHistorico", new[] { "CartaoId" });
            DropIndex("dbo.Cartao", new[] { "PublicadorId" });
            DropIndex("dbo.Cartao", new[] { "OperadoraId" });
            DropIndex("dbo.Cartao", new[] { "CongregacaoId" });
            DropTable("dbo.SimNao");
            DropTable("dbo.ContatoHistorico");
            DropTable("dbo.Contato");
            DropTable("dbo.Operadora");
            DropTable("dbo.SequenciaNumerica");
            DropTable("dbo.UnidadeFederacao");
            DropTable("dbo.Municipio");
            DropTable("dbo.Congregacao");
            DropTable("dbo.Publicador");
            DropTable("dbo.CartaoHistorico");
            DropTable("dbo.Cartao");
        }
    }
}

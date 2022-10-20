using System;
using System.IO;

namespace GerenciadorContatos.Dominio
{
    public static class Configuracao
    {
        public static string StringConexao { get; set; }
        public static string PathDatabase { get; set; }

        static Configuracao()
        {
            var pastaExecutavel = AppDomain.CurrentDomain.BaseDirectory;
            var pastaExecutavelInformacao = new DirectoryInfo(pastaExecutavel);
            var pastaProjeto = string.Empty;
#if DEBUG
            if (pastaExecutavel.Contains("GerenciadorContatos.Tests"))
            {
                pastaProjeto = pastaExecutavelInformacao.Parent.Parent.Parent.Parent.FullName;
                if (!pastaProjeto.EndsWith(@"\"))
                    pastaProjeto += @"\";
                pastaProjeto += @"src\GerenciadorContatos\";
            }
            else
                pastaProjeto = pastaExecutavelInformacao.Parent.Parent.FullName;
#else
            pastaProjeto = pastaExecutavelInformacao.FullName;
#endif

            if (!pastaProjeto.EndsWith(@"\"))
                pastaProjeto += @"\";

            PathDatabase = $@"{pastaProjeto}App_Data\";

            StringConexao = $@"Data Source={pastaProjeto}App_Data\GerenciadorContatos.db;Foreign Keys=True;";

        }
    }
}

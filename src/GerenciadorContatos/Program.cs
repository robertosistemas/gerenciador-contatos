using GerenciadorContatos.Aplicacao;
using GerenciadorContatos.Aplicacao.Abstracoes.Excecoes;
using GerenciadorContatos.Excecoes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace GerenciadorContatos
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AutoMapeamento.InicializaAutoMapper();
            InjecaoDependencia.ConfigureServices();
            InjecaoDependencia.Services.AddTransient<IErrorHandler, FormErrorHandler>();
            InjecaoDependencia.ConstruirProvedorServico();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

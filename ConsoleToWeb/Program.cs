using ConsoleToWeb.Negocio;
using ConsoleToWeb.Repositorio;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace ConsoleToWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebHost host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
            
            host.Run();
                

            //var _repo = new FilmeRepositorio();
            //ImprimeLista(_repo.ParaVer);
            //ImprimeLista(_repo.Vistos);
        }

        static void ImprimeLista(ListaDeFilmes lista)
        {
            Console.WriteLine(lista);
        }

    }
}

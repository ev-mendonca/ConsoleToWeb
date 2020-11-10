using ConsoleToWeb.Negocio;
using ConsoleToWeb.Repositorio;
using System;

namespace ConsoleToWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            var _repo = new FilmeRepositorio();
            ImprimeLista(_repo.ParaVer);
            ImprimeLista(_repo.Vistos);
        }

        static void ImprimeLista(ListaDeFilmes lista)
        {
            Console.WriteLine(lista);
        }

    }
}

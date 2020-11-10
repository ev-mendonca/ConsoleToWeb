using ConsoleToWeb.Negocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleToWeb.Repositorio
{
    interface IFilmeRepositorio
    {
        ListaDeFilmes ParaVer { get; }
        ListaDeFilmes Vistos { get; }
    }
}

using ConsoleToWeb.Negocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleToWeb.Repositorio
{
    public class FilmeRepositorio : IFilmeRepositorio
    {
        private static readonly string nomeArquivoCSV = "Repositorio\\filmes.csv";

        private ListaDeFilmes _paraVer;
        private ListaDeFilmes _vistos;

        public FilmeRepositorio()
        {
            var arrayParaVer = new List<Filme>();
            var arrayVistos = new List<Filme>();

            using (var file = File.OpenText(FilmeRepositorio.nomeArquivoCSV))
            {
                while (!file.EndOfStream)
                {
                    var textoFilme = file.ReadLine();
                    if (string.IsNullOrEmpty(textoFilme))
                    {
                        continue;
                    }
                    var infoFilme = textoFilme.Split(';');
                    var filme = new Filme
                    {
                        Id = Convert.ToInt32(infoFilme[1]),
                        Titulo = infoFilme[2],
                        Genero = infoFilme[3]
                    };
                    switch (infoFilme[0])
                    {
                        case "para-ver":
                            arrayParaVer.Add(filme);
                            break;
                        case "vistos":
                            arrayVistos.Add(filme);
                            break;
                        default:
                            break;
                    }
                }
            }

            _paraVer = new ListaDeFilmes("Para Ver", arrayParaVer.ToArray());
            _vistos = new ListaDeFilmes("Vistos", arrayVistos.ToArray());
        }

        public ListaDeFilmes ParaVer => _paraVer;
        public ListaDeFilmes Vistos => _vistos;

    }
}

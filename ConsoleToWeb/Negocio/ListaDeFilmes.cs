using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleToWeb.Negocio
{
    public class ListaDeFilmes
    {
        private List<Filme> _filmes;

        public ListaDeFilmes(string titulo, params Filme[] filmes)
        {
            Titulo = titulo;
            _filmes = filmes.ToList();
            _filmes.ForEach(f => f.Lista = this);
        }

        public string Titulo { get; set; }
        public IEnumerable<Filme> Filmes
        {
            get { return _filmes; }
        }

        public override string ToString()
        {
            var linhas = new StringBuilder();
            linhas.AppendLine(Titulo);
            linhas.AppendLine("=========");
            foreach (var filme in Filmes)
            {
                linhas.AppendLine(filme.ToString());
            }
            return linhas.ToString();
        }
    }
}

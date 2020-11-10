using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleToWeb.Negocio
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public ListaDeFilmes Lista { get; set; }

        public string Detalhes()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Detalhes do Filme");
            stringBuilder.AppendLine("=====");
            stringBuilder.AppendLine($"Título: {Titulo}");
            stringBuilder.AppendLine($"Gênereo: {Genero}");
            stringBuilder.AppendLine($"Lista: {Lista.Titulo}");
            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return $"{Titulo} - {Genero}";
        }
    }
}

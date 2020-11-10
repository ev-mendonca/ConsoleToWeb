using ConsoleToWeb.Repositorio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleToWeb
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app) 
        {
            app.Run(Roteamento);
        }

        public Task Roteamento(HttpContext context)
        {
            var _repo = new FilmeRepositorio();
            var caminhosAtendidos = new Dictionary<string, string>
            {
                {"/Filmes/ParaVer",_repo.ParaVer.ToString() },
                {"/Filmes/Vistos", _repo.Vistos.ToString() }
            };

            if(caminhosAtendidos.ContainsKey(context.Request.Path))
            {
                return context.Response.WriteAsync(caminhosAtendidos[context.Request.Path]);
            }

            return context.Response.WriteAsync(context.Request.Path);
        }

        public Task FilmesParaVer(HttpContext contexto)
        {
            var _repo = new FilmeRepositorio();
            return contexto.Response.WriteAsync(_repo.ParaVer.ToString());
        }
    }
}
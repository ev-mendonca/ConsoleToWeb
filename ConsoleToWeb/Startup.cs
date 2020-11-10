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
            var caminhosAtendidos = new Dictionary<string, RequestDelegate>
            {
                {"/Filmes/ParaVer", FilmesParaVer},
                {"/Filmes/Vistos", FilmesVistos }
            };

            if(caminhosAtendidos.ContainsKey(context.Request.Path))
            {
                var requestDelegate = caminhosAtendidos[context.Request.Path];
                return requestDelegate.Invoke(context);
            }

            context.Response.StatusCode = 404;
            return context.Response.WriteAsync(context.Request.Path);
        }

        public Task FilmesParaVer(HttpContext contexto)
        {
            var _repo = new FilmeRepositorio();
            return contexto.Response.WriteAsync(_repo.ParaVer.ToString());
        }

        public Task FilmesVistos(HttpContext contexto)
        {
            var _repo = new FilmeRepositorio();
            return contexto.Response.WriteAsync(_repo.Vistos.ToString());
        }
    }
}
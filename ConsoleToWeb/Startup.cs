using ConsoleToWeb.Repositorio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ConsoleToWeb
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app) 
        {
            app.Run(FilmesParaVer);
        }

        public Task FilmesParaVer(HttpContext contexto)
        {
            var _repo = new FilmeRepositorio();
            return contexto.Response.WriteAsync(_repo.ParaVer.ToString());
        }
    }
}
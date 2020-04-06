using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEGIN.NET.CORE
{
    public class MeuMiddleware
    {
        private readonly RequestDelegate _next;

        public MeuMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {

            Console.WriteLine("INICIANDO ÁS " + DateTime.Now);
            await _next(context);
            Console.WriteLine("TERMINADO ÁS " + DateTime.Now);
        }


    }
}

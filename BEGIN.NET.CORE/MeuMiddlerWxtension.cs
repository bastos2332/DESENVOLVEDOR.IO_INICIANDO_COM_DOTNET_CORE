using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEGIN.NET.CORE
{
    public static class MeuMiddlerWxtension
    {
        public static IApplicationBuilder UseMeuMiddler(this IApplicationBuilder app)
        {
            return app.UseMiddleware<MeuMiddleware>();
        }
    }
}

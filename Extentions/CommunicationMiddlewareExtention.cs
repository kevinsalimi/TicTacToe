using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Middleware;

namespace TicTacToe.Extentions
{
    public static class CommunicationMiddlewareExtention
    {
        public static IApplicationBuilder UesCommunicationMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<CommunicationMiddleware>();
        }
    }
}

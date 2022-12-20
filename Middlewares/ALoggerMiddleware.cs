using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using ALogger.Services.Interfaces;
using ALogger.Tools.Interfaces;

namespace ALogger.Logger.Middlewares
{
    public class ALoggerMiddleware
    {
        private readonly RequestDelegate _next;
        public ALoggerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            IDisplay._request = context.Request;

            //var request = context.Request;
            //var query = request.Query;
            //var content = query["content"].ToString();
            //var id = query["id"].ToString();

            //Console.WriteLine($" Request id : {request}");

            //if (content != null || content != "")
            //    Console.WriteLine($" Content : {content}");
            //if (content != null || content != "")
            //    Console.WriteLine($" Id : {id}");

            //foreach (var header in request.Headers)
            //{
            //    Console.WriteLine($" HEADER : {header}");
            //}

            await _next(context);
        }
        
    }

    public static class ALoggerMiddlewareExtensions
    {
        public static IApplicationBuilder UseALoggerMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ALoggerMiddleware>();
        }
    }
}

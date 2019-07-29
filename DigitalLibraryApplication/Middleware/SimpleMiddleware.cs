using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace DigitalLibraryApplication.Middleware
{
    public class SimpleMiddleware
    {
        private readonly RequestDelegate _next;

        public SimpleMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task InvokeAsync(HttpContext context)
        {
            return this._next(context);
        }
    }
}

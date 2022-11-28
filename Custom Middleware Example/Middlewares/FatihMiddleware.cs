using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Custom_Middleware_Example.Middlewares
{
    public class FatihMiddleware
    {
        RequestDelegate _next;

        public FatihMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            //Custom Operasyon
            Console.WriteLine("Fatih Sarıdağ Başlangıç Middleware");
            await _next.Invoke(httpContext); // Bizden sonraki middlewarei tetikledik.
            Console.WriteLine("Fatih Sarıdağ Bitiş Middleware"); // Middlewareden tekrar geldikten sonra response olarak 


        }


    }
}

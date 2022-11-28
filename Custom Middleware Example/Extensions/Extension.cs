using Custom_Middleware_Example.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace Custom_Middleware_Example.Extensions
{
    static public class Extension
    {
        public static IApplicationBuilder UseFatih(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<FatihMiddleware>();
        }
    }
}

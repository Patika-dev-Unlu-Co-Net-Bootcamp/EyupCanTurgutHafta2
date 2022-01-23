using Microsoft.AspNetCore.Builder;

namespace UnluCoBootCamp.Odev1.Api
{
    public static class ApplicationBuilderExtension
    {
        public static void CustomExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
        
    }
}

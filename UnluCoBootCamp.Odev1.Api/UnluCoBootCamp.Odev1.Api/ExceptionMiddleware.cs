using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using System.Threading.Tasks;

namespace UnluCoBootCamp.Odev1.Api
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate requestDelegate)
        {
            _next = requestDelegate;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {

                await _next(httpContext);
            }
            catch (Exception ex)
            {

                httpContext.Response.ContentType = "application/json";
                httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;//500 dondur
                await httpContext.Response.WriteAsync(System.Text.Json.JsonSerializer.Serialize(new { StatusCode = httpContext.Response.StatusCode, Message = ex.Message}));
            }
        }
    }
}

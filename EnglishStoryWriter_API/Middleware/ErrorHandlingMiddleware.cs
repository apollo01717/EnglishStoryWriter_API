using EnglishStoryWriter_API.Exceptions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Middleware
{
    public class ErrorHandlingMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next.Invoke(context);
            }
            catch(BadRequestException badRequestException)
            {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsync(badRequestException.Message);
            }
            catch (NotFoundException exception)
            {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsync(exception.Message);
            }
            catch(Exception exception)
            {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsync("Something went wrong");
            }
        }
    }
}

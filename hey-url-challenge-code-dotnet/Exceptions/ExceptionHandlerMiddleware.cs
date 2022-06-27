using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Diagnostics;
using hey_url_challenge_code_dotnet.Models;

namespace hey_url_challenge_code_dotnet.Exceptions
{
    public class ExceptionHandlerMiddleware:IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {

            try
            {
               await next(context);
                
            }
            catch (DomainInvalidUrlException e)
            {
                
                context.Response.ContentType = "text/html";                               
                var err = $"<h1>404 - Page not found</h1>"+
                            "<p> Oops, better check that URL."+e.Message+"</p>";
                await context.Response.WriteAsync(err).ConfigureAwait(false);
            }
            catch (DomaininternalServerException e)
            {
                context.Response.ContentType = "text/html";
                var err = $"<h1>500 - Page Internal Server Error</h1>" +
                            "<p> Oops, Unable to process your request." + e.Message + "</p>";
                await context.Response.WriteAsync(err).ConfigureAwait(false);

            }
            catch (DomainBadRequestException e)
            {
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;

                JsonResult result = new JsonResult(new ResponseData<Url>()
                {

                    Code = EResponse.BadRequest.ToString(),
                    Status = StatusCodes.Status400BadRequest,
                    Data = Array.Empty<Url>(),
                    Message = e.Message
                })
                {
                    StatusCode = StatusCodes.Status400BadRequest

                };
                var routeData = context.GetRouteData();
                ActionDescriptor actionDescriptor = new ActionDescriptor();
                ActionContext actionContext = new ActionContext(context, routeData, actionDescriptor);
                await result.ExecuteResultAsync(actionContext);
            }
        }

}
}

﻿using ApplicationDomain.Exceptions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebPresentation.Midlewares
{
    public class ExceptionHandler
    {

        private readonly RequestDelegate _next;

        public ExceptionHandler(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (DomainException ex)
            {

                httpContext.Response.Redirect("/Home/Error");
            }

            catch (Exception ex)
            {

                await HandleExceptionAsync(httpContext, ex);
            }
        }

    private static Task HandleExceptionAsync(HttpContext context, Exception exception)  
    {
            //log it then redirect 
            context.Response.Redirect("/Home/Error");
        return Task.CompletedTask;
    }

    }
}

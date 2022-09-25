using System.Net.Mime;
using System.Net;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Filters;

public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        var exception = context.Exception;

        var errorResult = new { error = "An error occurred while processing your request."};

        context.Result = new ObjectResult(errorResult)
        {
            StatusCode = 500
        };

        context.ExceptionHandled = true;
    }
}
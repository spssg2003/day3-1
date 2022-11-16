using Microsoft.AspNetCore.Mvc.Filters;

namespace CoursesApi;

public class OperationCancelledExceptionFilterAttribute : ExceptionFilterAttribute
{
    private readonly ILogger<OperationCancelledExceptionFilterAttribute> _logger;

    public OperationCancelledExceptionFilterAttribute(ILogger<OperationCancelledExceptionFilterAttribute> logger)
    {
        _logger = logger;
    }

    public override void OnException(ExceptionContext context)
    {
        if(context.Exception is OperationCanceledException)
        {
            _logger.LogInformation("Request was cancelled before completing");
            context.ExceptionHandled = true;
            context.Result = new StatusCodeResult(400);
        }
    }
}

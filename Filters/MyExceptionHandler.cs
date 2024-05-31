using Microsoft.AspNetCore.Diagnostics;

namespace PersonelApp.WebAPI.Filters;

public sealed class MyExceptionHandler : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext context, Exception exception, CancellationToken cancellationToken)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = 500;
        await context.Response.WriteAsync(exception.Message);
        return true;
    }
}

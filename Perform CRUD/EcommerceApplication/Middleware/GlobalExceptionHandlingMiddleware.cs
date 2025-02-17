using Microsoft.AspNetCore.Http.HttpResults;
using System.Net;
using System.Text.Json;

namespace EcommerceApplication.Middleware
{
    public class GlobalExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        public GlobalExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch(Exception ex)
            {
                await HandlerExceptionAsync(context, ex);
            }
        }
        public async Task HandlerExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            var response = context.Response;
            ResponseModel exModel = new ResponseModel();
            switch (exception)
            {
                case ApplicationException:
                    exModel.responseCode = (int)HttpStatusCode.BadRequest;
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                    exModel.responseMessage = exception.Message;
                    break;
                case FileNotFoundException:
                    exModel.responseCode = (int)HttpStatusCode.NotFound;
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    exModel.responseMessage = exception.Message;
                    break;
                default:
                    exModel.responseCode = (int)HttpStatusCode.InternalServerError;
                    response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    exModel.responseMessage = "Internal server error. Please try later.";
                    break;
            }
            var result = JsonSerializer.Serialize(exModel);
            await context.Response.WriteAsync(result);
        }
    }
}

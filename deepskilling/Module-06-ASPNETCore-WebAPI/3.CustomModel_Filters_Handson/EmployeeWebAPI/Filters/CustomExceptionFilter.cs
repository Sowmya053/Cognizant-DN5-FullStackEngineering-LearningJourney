using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EmployeeWebAPI.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            File.AppendAllText(
                "ErrorLog.txt",
                DateTime.Now + Environment.NewLine +
                context.Exception.Message + Environment.NewLine);

            context.Result = new ObjectResult("Internal Server Error")
            {
                StatusCode = 500
            };
        }
    }
}
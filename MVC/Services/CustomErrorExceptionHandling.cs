using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;

namespace MVC.Services
{
    public class CustomErrorExceptionHandling : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            if (context.Exception is NotImplementedException)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent("This method is not implemented"),
                    ReasonPhrase = "Not implemented"
                };
                throw new HttpResponseException(resp);
            }else if(context.Exception is Exception)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent("server"),
                    
                };
                throw new HttpResponseException(resp);
            }
        }
    }
}
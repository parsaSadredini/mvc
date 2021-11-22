using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
namespace MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        //protected virtual void Application_Error(object sender, EventArgs e)
        //{
        //    var exception = Server.GetLastError();
        //    Response.Clear();

        //    var httpException = exception as HttpException;

        //    if (httpException != null)
        //    {
        //        var action = string.Empty;

        //        switch (httpException.GetHttpCode())
        //        {
        //            case 401:
        //                action = "Unauthorized";
        //                break;
        //            case 403:
        //                action = "Forbidden";
        //                break;
        //            case 404:
        //                action = "NotFound";
        //                break;
        //            case 500:
        //                action = "ServerError";
        //                break;
        //            default:
        //                action = "ServerError";
        //                break;
        //        }

        //        Server.ClearError();

        //        Response.Redirect(string.Format("~/Error/{0}/?message={1}", action, exception.Message));
        //    }
        //    else
        //    {
        //        Response.Redirect(string.Format("~/Error/server"));
        //    }

        //}
    }
}

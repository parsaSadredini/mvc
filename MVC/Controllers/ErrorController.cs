using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MVC.Controllers
{
    public class ErrorController : Controller
    {
       public ActionResult NotFound()
        {
            return View();
        }
        public ActionResult server()
        {

            return View();
        }
        public string core()
        {
            var error = Server.GetLastError();
            return "core";

            //switch (error.GetHttpCode())
            //{
            //    case 403:
            //        return "you are unAuthorized";
            //    default:
            //        return "Error has accured";
            //}
        }
    }
}
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC.Controllers
{
    
    public class HomeController : Controller
    {
        protected override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
            string action = filterContext.RouteData.Values["action"].ToString();
            Exception e = filterContext.Exception;
            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult()
            {
                ViewName = "Error"
            };
        }
        public ActionResult Index()
        {
           
           return View();
        }

        [Authorize(Roles ="admin")]
        public ActionResult Test()
        {
            return View();
        }

        [Authorize(Roles ="test")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = User.Identity.Name;
            

            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(HUser user,string ReturnUrl)
        {
            FormsAuthentication.SetAuthCookie(user.username, false);

            return Redirect(ReturnUrl);

        }
        public ActionResult fuck()
        {
            throw new Exception();
        }
    }
}
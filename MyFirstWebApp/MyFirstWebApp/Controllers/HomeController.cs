using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        // Controllers handle incoming http requests, builds the model, and returns
        // the wrapped model data in the defined view
        public ActionResult Index()
        {
            // The Action result method name is mapped to the corresponding
            // page name in the respective controllers views directory
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
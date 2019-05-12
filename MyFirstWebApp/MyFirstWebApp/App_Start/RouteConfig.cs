using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyFirstWebApp
{
    public class RouteConfig
    {
        // Routes define how requests are handled within the app
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Custom route example
            routes.MapRoute(
                name: "testRoute",
                url: "Home/Contact-us", 
                defaults: new { controller = "Home", action = "Contact" }
            );

            // Determines what method - in this case the index action result from the home controller
            // (which returns the index view) is invoked when the defined url is hit
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}", // Pattern
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Handler
            );                    
        }
    }
}

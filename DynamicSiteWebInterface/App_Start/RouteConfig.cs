using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DynamicSite
{
    public class RouteConfig
    {
        private static List<string> SimplePages = new List<string> { "Page1", "Page2", "Page3" };

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            AddSmplePageRoutes(routes);
        }

        private static void AddSmplePageRoutes(RouteCollection routes)
        {
            foreach (var page in SimplePages)
            {
                routes.MapRoute(
                    string.Join("_", "SimplePageRoute", page),
                    "{id}",
                    new { controller = "Home", action = "SimplePage", id = page }
                    );
            }
        }
    }
}

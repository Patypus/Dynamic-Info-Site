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
        private static List<string> OtherPages = new List<string> { "Page5" };

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            
            AddSmplePageRoutes(routes);
            AddOtherPageRoutes(routes);

            routes.MapRoute(name: "Default",
                            url: "{controller}/{action}/{id}",
                            defaults: new { controller = "Home", action = "MainPage", id = UrlParameter.Optional });
        }

        private static void AddSmplePageRoutes(RouteCollection routes)
        {
            foreach (var page in SimplePages)
            {
                routes.MapRoute(
                    string.Join("_", "SimplePageRoute", page),
                    page,
                    new { controller = "Home", action = "SimplePage", id = page });
            }
        }

        private static void AddOtherPageRoutes(RouteCollection routes)
        {
            foreach (var page in OtherPages)
            {
                routes.MapRoute(
                    string.Join("_", "OtherPageRoute", page),
                    page,
                    new { controller = "Home", action = "OtherPage", id = page });
            }
        }
    }
}

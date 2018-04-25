using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Project
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Category",
                url: "lua-chon/{meta}-{categoryID}",
                defaults: new { controller = "Home", action = "Category", id = UrlParameter.Optional },
                namespaces: new[] { "Project.Controllers" }
            );
            routes.MapRoute(
                name: "lienhe",
                url: "lienhe",
                defaults: new { controller = "LienHe", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Project.Controllers" }
            );
            routes.MapRoute(
                name: "ProductDetail",
                url: "san-pham/{productID}",
                defaults: new { controller = "Home", action = "ProductDetail", meta = UrlParameter.Optional },
                namespaces: new[] { "Project.Controllers" }
            );
            routes.MapRoute(
                     name: "NewsDetail",
                     url: "tin-tuc/{NewsID}",
                     defaults: new { controller = "Home", action = "NewsDetail", meta = UrlParameter.Optional },
                     namespaces: new[] { "Project.Controllers" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Project.Controllers" }
            );
        }
    }
}

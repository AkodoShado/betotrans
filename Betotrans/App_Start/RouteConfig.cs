using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Betotrans
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Oferta",
                url: "Oferta",
                defaults: new { controller = "Home", action = "Offer", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ZaufaliNam",
                url: "Zaufali_Nam",
                defaults: new { controller = "Home", action = "Reference", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Kontakt",
                url: "Kontakt",
                defaults: new { controller = "Home", action = "Contact", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "OFirmie",
                url: "O_Firmie",
                defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
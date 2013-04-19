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
                name: "Kruszywo",
                url: "Kruszywo",
                defaults: new { controller = "Home", action = "Kruszywo", nazwa = "Pospolka", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Kruszywo-Pospolka",
                url: "Kruszywo-Pospolka",
                defaults: new { controller = "Home", action = "Kruszywo", nazwa = "Pospolka" }
            );

            routes.MapRoute(
                name: "Kruszywo-Piasek-Kopalniany",
                url: "Kruszywo-Piasek-Kopalniany",
                defaults: new { controller = "Home", action = "Kruszywo", nazwa = "Piasek-Kopalniany" }
            );

            routes.MapRoute(
                name: "Kruszywo-Piasek-Plukany",
                url: "Kruszywo-Piasek-Plukany",
                defaults: new { controller = "Home", action = "Kruszywo", nazwa = "Piasek-Plukany" }
            );

            routes.MapRoute(
                name: "Kruszywo-Piasek-Plukany-05-2",
                url: "Kruszywo-Piasek-Plukany-05-2",
                defaults: new { controller = "Home", action = "Kruszywo", nazwa = "Piasek-Plukany-05-2" }
            );

            routes.MapRoute(
                name: "Kruszywo-Mieszanka-do-betonu-0-16",
                url: "Kruszywo-Mieszanka-do-betonu-0-16",
                defaults: new { controller = "Home", action = "Kruszywo", nazwa = "Mieszanka-do-betonu-0-16" }
            );

            routes.MapRoute(
                name: "Kruszywo-Zwir-2-8",
                url: "Kruszywo-Zwir-2-8",
                defaults: new { controller = "Home", action = "Kruszywo", nazwa = "Zwir-2-8" }
            );

            routes.MapRoute(
                name: "Kruszywo-Zwir-2-16",
                url: "Kruszywo-Zwir-2-16",
                defaults: new { controller = "Home", action = "Kruszywo", nazwa = "Zwir-2-16" }
            );

            routes.MapRoute(
                name: "Kruszywo-Zwir-8-16",
                url: "Kruszywo-Zwir-8-16",
                defaults: new { controller = "Home", action = "Kruszywo", nazwa = "Zwir-8-16" }
            );

            routes.MapRoute(
                name: "Kruszywo-Zwir-16-35",
                url: "Kruszywo-Zwir-16-35",
                defaults: new { controller = "Home", action = "Kruszywo", nazwa = "Zwir-16-35" }
            );

            routes.MapRoute(
                name: "Kruszywo-Kwarcyt",
                url: "Kruszywo-Kwarcyt",
                defaults: new { controller = "Home", action = "Kruszywo", nazwa = "Kwarcyt" }
            );

            routes.MapRoute(
                name: "Kruszywo-Dolomit",
                url: "Kruszywo-Dolomit",
                defaults: new { controller = "Home", action = "Kruszywo", nazwa = "Dolomit" }
            );

            routes.MapRoute(
                name: "Kruszywo-Wapien",
                url: "Kruszywo-Wapien",
                defaults: new { controller = "Home", action = "Kruszywo", nazwa = "Wapien" }
            );

            routes.MapRoute(
                name: "Kruszywo-Zwir-16-32",
                url: "Kruszywo-Zwir-16-32",
                defaults: new { controller = "Home", action = "Kruszywo", nazwa = "Zwir-16-32" }
            );

            routes.MapRoute(
                name: "Kruszywo-Glazy",
                url: "Kruszywo-Glazy",
                defaults: new { controller = "Home", action = "Kruszywo", nazwa = "Glazy" }
            );

            routes.MapRoute(
                name: "Kruszywo-Torf",
                url: "Kruszywo-Torf",
                defaults: new { controller = "Home", action = "Kruszywo", nazwa = "Torf" }
            );

            routes.MapRoute(
                name: "Oferta",
                url: "Sprzedaz-kruszyw",
                defaults: new { controller = "Home", action = "Offer", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ZaufaliNam",
                url: "Zaufali-Nam",
                defaults: new { controller = "Home", action = "Reference", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Kontakt",
                url: "Kontakt",
                defaults: new { controller = "Home", action = "Contact", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "OFirmie",
                url: "O-Firmie",
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
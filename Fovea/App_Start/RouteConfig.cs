using System.Web.Mvc;
using System.Web.Routing;

namespace Fovea
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Business",
                url: "business/{id}",
                defaults: new { controller = "Business", action = "Details" },
                constraints: new { id = @"\d+" }
            );
            routes.MapRoute(
                name: "sell-a-business",
                url: "sell-a-business",
                defaults: new { controller = "Business", action = "sell-a-business" }
               // constraints: new { id = @"\d+" }
            );
            routes.MapRoute(
                name: "register-business",
                url: "register-business",
                defaults: new { controller = "Business", action = "register-business" }
            // constraints: new { id = @"\d+" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
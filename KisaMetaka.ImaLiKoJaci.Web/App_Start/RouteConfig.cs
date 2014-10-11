using System.Web.Mvc;
using System.Web.Routing;

namespace KisaMetaka.ImaLiKoJaci.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("FacebookLogin", "login", new { controller = "Login", action = "FacebookLogin" });
            routes.MapRoute("FacebookCallback", "fbcallback", new { controller = "Login", action = "FacebookCallback" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Shell", action = "Shell", id = UrlParameter.Optional }
            );
        }
    }
}
﻿using System.Web.Mvc;
using System.Web.Routing;

namespace WebMVCBasics
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            // Add "Hello" route with route data for name and ID parameters
            routes.MapRoute(
                name: "Hello",
                url: "{controller}/{action}/{name}/{numTimes}"            
            );
        }
    }
}

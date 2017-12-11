using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace moviemall
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            ////create custom routes for the project. 
            //routes.MapRoute(
            //       "MovieRouteByReleaseDate", // This will be pattern of the addres and the controller and action will be decided based on the below 3rd object parameter
            //       "movies/released/{years}/{months}",
            //        new { Controller = "Movies", action = "ByReleaseDate" },
            //        //new { years = @"\d{4}",months = @"\d{2}"}
            //        new { years = "2001|2002", months = @"\d{2}" }
            //    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace kitchentime.web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                    name: "Omoss",
                    url: "Omoss",
                    defaults: new { controller = "Home", action = "Omoss", id = UrlParameter.Optional }

               );

            routes.MapRoute(
                name: "Kontakt",
                url: "Kontakt",
                defaults: new { controller = "Home", action = "Kontakt", id = UrlParameter.Optional }

           );

            routes.MapRoute(
                    name: "upplevelser",
                    url: "Upplevelser",
                    defaults: new { controller = "Upplevelser", action = "Index", id = UrlParameter.Optional }
               );


                routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action =  "Index",  id = UrlParameter.Optional }

           );
                  

                


        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace eUseControl.Web
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
            routes.MapRoute(
                name: "SecondPage",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "SecondPage", action = "SecondPage", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "SignUp",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "SignUp", action = "SignUp", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Subscription",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Subscription", action = "Subscription", id = UrlParameter.Optional }
            );
        }
    }
}

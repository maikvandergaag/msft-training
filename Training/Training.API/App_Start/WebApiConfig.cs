﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Api {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            // Web Api configuration and services

            // Web Api routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "Api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

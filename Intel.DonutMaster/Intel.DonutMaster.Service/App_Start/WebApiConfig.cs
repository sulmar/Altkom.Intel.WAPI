using Intel.DonutMaster.Service.Formatters;
using Intel.DonutMaster.Service.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Intel.DonutMaster.Service
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            config.MessageHandlers.Add(new TraceMessageHandler());
            config.MessageHandlers.Add(new SecretKeyHandler());


            config.Formatters.Add(new QrCodeFormatter());
        }
    }
}

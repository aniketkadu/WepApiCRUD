using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;

namespace webapicrud
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var settings = config.Formatters.JsonFormatter.SerializerSettings;

            config.Formatters.JsonFormatter.SupportedMediaTypes
           .Add(new MediaTypeHeaderValue("text/html"));
           



            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //settings.Formatting = Formatting.Indented;
            //config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

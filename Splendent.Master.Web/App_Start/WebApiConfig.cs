using System.Web.Http;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Splendent.Master.Dependency.Resolver;

namespace Splendent.Master.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //GlobalConfiguration.Configuration.DependencyResolver = new Unity.Mvc5.UnityDependencyResolver(UnityConfig.Container);
            //GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator), new UnityWebApiControllerActivator(UnityConfig.Container));

            config.DependencyResolver = new UnityResolver(UnityConfig.Container);


            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = NullValueHandling.Ignore
            };

            config.Formatters.JsonFormatter.SerializerSettings = settings;
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //// enable API versioning                   
            //GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerSelector), new RouteVersionControllerSelector(GlobalConfiguration.Configuration));
            //GlobalConfiguration.Configuration.Services.Replace(typeof(IApiExplorer), new VersionedApiExplorer(GlobalConfiguration.Configuration));
            //GlobalConfiguration.Configuration.Services.Replace(typeof(IDocumentationProvider),
            //                        new XmlCommentDocumentationProvider(System.IO.Path.GetDirectoryName(
            //                            System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) +
            //                                                            "\\Adventure.Api.v1.XML"));

            //config.Routes.MapHttpRoute(
            //    name: "DefaultVersionApi",
            //    routeTemplate: "api/v{version}/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}

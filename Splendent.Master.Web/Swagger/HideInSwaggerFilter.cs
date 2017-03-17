using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;

namespace Splendent.Master.Web.Swagger
{
    public class HideInSwaggerFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, SchemaRegistry schemaRegistry, IApiExplorer apiExplorer)
        {
            foreach(var apiDescription in apiExplorer.ApiDescriptions)
            {
                if (!apiDescription.ActionDescriptor.ControllerDescriptor.GetCustomAttributes<HideInSwaggerAttribute>().Any() && !apiDescription.ActionDescriptor.GetCustomAttributes<HideInSwaggerAttribute>().Any()) continue;
                var route = "/" + apiDescription.RelativePath.TrimEnd('/');
                swaggerDoc.paths.Remove(route);
            }
        }
    }
}
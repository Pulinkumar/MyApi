using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Splendent.Master.Web.Swagger
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class HideInSwaggerAttribute : Attribute
    {
    }
}
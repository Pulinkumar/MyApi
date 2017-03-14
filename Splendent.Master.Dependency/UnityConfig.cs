using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Splendent.Masters.BusinessLogic;
using Splendent.Master.BusinessLogic.Interfaces;
using Microsoft.Practices.Unity;
using System.Diagnostics.CodeAnalysis;

namespace Splendent.Master.Dependency
{
    [ExcludeFromCodeCoverage]
    public static class UnityConfig
    {
        public static void Configure(IUnityContainer container)
        {

            container.RegisterType<IEmployeeBL, EmployeeBL>(new PerThreadLifetimeManager());
           
        }
    }
}

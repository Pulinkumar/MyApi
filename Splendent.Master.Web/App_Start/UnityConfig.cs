using Microsoft.Practices.Unity;
using System;

namespace Splendent.Master.Web
{
    public static class UnityConfig
    {
        private static readonly Lazy<IUnityContainer> _container = new Lazy<IUnityContainer>(() => new UnityContainer());

        public static IUnityContainer Container => _container.Value;

        public static void RegisterComponents()
        {
            Dependency.UnityConfig.Configure(Container);
        }
    }
}
using Microsoft.Practices.Unity;
using MyApp.Service;
using MyApp.Service.Contracts;
using System.Web.Http;
using Unity.WebApi;

namespace MyApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            

            container.RegisterType<IHelloWorldService, HelloWorldService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}
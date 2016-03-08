using SGA.Infrastructure.SharedKernel.IoC;
using SGA.Web.DependencyResolution;
using StructureMap;
using System.Globalization;
using System.Threading;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SGA.Web
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var container = IoC.Initialize();

            var config = GlobalConfiguration.Configuration;
            config.Services.Replace(typeof(IHttpControllerActivator), new ServiceActivator(container));

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_BeginRequest()
        {
            Thread.CurrentThread.CurrentCulture
              = CultureInfo.CreateSpecificCulture("pt-BR");
        }

        protected void Application_EndRequest()
        {
            StructuremapMvc.StructureMapDependencyScope?.CurrentNestedContainer?.EjectAllInstancesOf<ILifecycleContext>();
        }
    }
}
using StructureMap;
using System.Web;

namespace SMC.Web.DependencyResolution
{
    public class StructureMapScopeModule : IHttpModule
    {
        public void Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += (sender, e) => StructuremapMvc.StructureMapDependencyScope.CreateNestedContainer();
            context.EndRequest += (sender, e) =>
            {
                StructuremapMvc.StructureMapDependencyScope.CurrentNestedContainer.EjectAllInstancesOf<ILifecycleContext>();
                StructuremapMvc.StructureMapDependencyScope.DisposeNestedContainer();
            };
        }
    }
}
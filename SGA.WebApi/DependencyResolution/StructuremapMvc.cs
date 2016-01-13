using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using SGA.Infrastructure.SharedKernel.IoC;
using System.Web.Mvc;

namespace SGA.WebApi.DependencyResolution
{
    public static class StructuremapMvc
    {
        #region Public Properties

        public static StructureMapDependencyScope StructureMapDependencyScope { get; set; }

        #endregion Public Properties

        #region Public Methods and Operators

        public static void End()
        {
            StructureMapDependencyScope.Dispose();
        }

        public static void Start()
        {
            var container = IoC.Initialize();
            StructureMapDependencyScope = new StructureMapDependencyScope(container);
            DependencyResolver.SetResolver(StructureMapDependencyScope);
            DynamicModuleUtility.RegisterModule(typeof(StructureMapScopeModule));
        }

        #endregion Public Methods and Operators
    }
}
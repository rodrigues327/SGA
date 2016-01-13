﻿using StructureMap;
using System.Web;

namespace SGA.WebApi.DependencyResolution
{
    public class StructureMapScopeModule : IHttpModule
    {
        #region Public Methods and Operators

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

        #endregion Public Methods and Operators
    }
}
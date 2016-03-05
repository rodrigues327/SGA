using StructureMap;
using System;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace SMC.Web.DependencyResolution
{
    public class ServiceActivator : IHttpControllerActivator
    {
        private readonly IContainer _container;

        public ServiceActivator(IContainer container)
        {
            _container = container;
        }

        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            return _container.GetInstance(controllerType) as IHttpController;
        }
    }
}
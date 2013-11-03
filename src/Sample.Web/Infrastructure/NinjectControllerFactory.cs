using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;

namespace Sample.Web.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private readonly IKernel kernel;

        public NinjectControllerFactory(IKernel kernel)
        {
            this.kernel = kernel;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType != null ? kernel.Get(controllerType) as IController : null;
        }
    }
}
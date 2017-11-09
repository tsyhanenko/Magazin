using Magazine.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Magazine.Infrastructure
{
    public class MyDR : IDependencyResolver
    {
        IKernel kernel;
        public MyDR()
        {
            kernel = new StandardKernel();

        }
        private void AddBindings()
        {
            kernel.Bind<IMyContext>().To<MyContext>();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}
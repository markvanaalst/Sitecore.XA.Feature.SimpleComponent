using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Sitecore.XA.Feature.SimpleComponent.Repositories;
using Sitecore.XA.Foundation.IOC.Pipelines.IOC;
using Sitecore.XA.Feature.SimpleComponent.Controllers;

namespace Sitecore.XA.Feature.SimpleComponent.Pipelines.IoC
{
    public class RegisterSimpleComponent : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ISimpleComponentRepository, SimpleComponentRepository>();
            serviceCollection.AddTransient<SimpleComponentController>();
        }
    }
}
using Autofac;
using Autofac.Integration.WebApi;
using Lhg.SoccerVirtual.Backend.AppServices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace Lhg.SoccerVirtual.Backend.App_Start
{
    public static class AutofacContainerConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;
            var assemblies = new Assembly[]
            {
                typeof(IMarketService).Assembly,


            };
            builder.RegisterAssemblyTypes(assemblies)
              .AsImplementedInterfaces()
              .InstancePerRequest();
            //register web api controllers
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());


            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            //return builder.Build();


        }
    }

}
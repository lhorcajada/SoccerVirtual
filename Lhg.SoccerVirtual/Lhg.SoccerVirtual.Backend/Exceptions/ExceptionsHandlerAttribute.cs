using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace Lhg.SoccerVirtual.Backend.Exceptions
{
    [ExcludeFromCodeCoverage]

    public class ExceptionsHandlerAttribute : ExceptionFilterAttribute
    {

        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {

            RegisterException(actionExecutedContext);
            base.OnException(actionExecutedContext);

        }
        private void RegisterException(HttpActionExecutedContext actionExecutedContext)
        {
            using (var httpRequestScope = actionExecutedContext.ActionContext.ControllerContext.Configuration.DependencyResolver.BeginScope())
            {
            }
        }


    }
}
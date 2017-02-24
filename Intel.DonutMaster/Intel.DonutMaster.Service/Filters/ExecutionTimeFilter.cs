using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Intel.DonutMaster.Service.Filters
{
    public class ExecutionTimeFilter : ActionFilterAttribute
    {

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            actionContext.Request.Properties[actionContext.ActionDescriptor.ActionName] = Stopwatch.StartNew();

            base.OnActionExecuting(actionContext);

        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            base.OnActionExecuted(actionExecutedContext);

            var stopwatch = (Stopwatch)actionExecutedContext.Request.Properties[actionExecutedContext.ActionContext.ActionDescriptor.ActionName];

            var actionName = actionExecutedContext.ActionContext.ActionDescriptor.ActionName;

            Trace.WriteLine($"{actionName} - elapsed - {stopwatch.Elapsed}");
        }

        
    }
}
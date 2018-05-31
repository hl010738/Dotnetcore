using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDemo.Filter
{
    public class GlobalActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            // do something before the action executes
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            // do something after the action executes
        }
    }
}

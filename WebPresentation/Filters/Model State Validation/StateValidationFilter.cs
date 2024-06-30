using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPresentation.ViewModels;

namespace WebPresentation.Filters.ModelStateValidation
{
    public class StateValidationFilter : ActionFilterAttribute
    {
        
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                Controller controller = context.Controller as Controller;
                if (controller != null)
                {
                    var model = context.ActionArguments.Values.Where(p=> p is not int    ).FirstOrDefault();
                    var actionName = context.ActionDescriptor.RouteValues["action"];
                    context.Result = controller.View(actionName, model);
                    return;
                }
                else
                {
                    context.Result = new BadRequestObjectResult(context.ModelState);
                }
            }
        }
    }
}

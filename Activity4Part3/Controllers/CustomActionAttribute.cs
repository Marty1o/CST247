using Activity1Part3.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part3.Controllers
{
    public class CustomActionAttribute : FilterAttribute, IActionFilter
    {

        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            string name = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName + ":" + filterContext.ActionDescriptor.ActionName;
            MyLogger1.GetInstance().Info("Just got to Custome controller: " + name);
        }

        void IActionFilter.OnActionExecuted(ActionExecutedContext filterContext)
        {
            string name = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName + ":" + filterContext.ActionDescriptor.ActionName;
            MyLogger1.GetInstance().Info("Just left custom controller: " + name);
        }

    }
}
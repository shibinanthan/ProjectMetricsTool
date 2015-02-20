using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Caching;
using System.Web.Routing;
using System.Web.Helpers;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Net;

namespace Cognizant.Tools.ProjectMetrics.ProjectMetricsUILayer.Filters
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class CustomAuthorizationAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            base.AuthorizeCore(httpContext);
            if (httpContext.Session["UserDetail"] != null)
            {
                return true;
            }
            return false;
        }

        public override void OnAuthorization(AuthorizationContext context)
        {
            base.OnAuthorization(context);

            if (context.HttpContext.Session["UserDetail"] == null)
            {
                context.Result = new RedirectToRouteResult(
                                    new RouteValueDictionary { { "controller", "Account" }, { "action", "Login" } });
            }
        }
    }
}
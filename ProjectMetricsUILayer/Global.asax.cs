using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Cognizant.Tools.ProjectMetrics.ProjectMetricsUILayer
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();

            //  Set Entity Connection String
            SetConnectionString();
        }

        public void SetConnectionString()
        {
            //  For Credentital Security
            Cognizant.Tools.ProjectMetrics.ConnectionManager.ConnectionManager.PMToolsEntityConnectionString = ConfigurationManager.ConnectionStrings["PMToolsDBString"].ToString();
            
            //  For intergrated security
            //Cognizant.Tools.ProjectMetrics.ConnectionManager.ConnectionManager.PMToolsEntityConnectionString = ConfigurationManager.ConnectionStrings["PMEntities"].ToString();
        }
    }
}
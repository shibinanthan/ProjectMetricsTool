using System.Web;
using System.Web.Mvc;

namespace Cognizant.Tools.ProjectMetrics.ProjectMetricsUILayer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
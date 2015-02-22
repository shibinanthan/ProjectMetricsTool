using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cognizant.Tools.ProjectMetrics.DataLayer;
using Cognizant.Tools.ProjectMetrics.BusinessService;
using Cognizant.Tools.ProjectMetrics.DataLayer.PM_EDMX;

namespace Cognizant.Tools.ProjectMetrics.ProjectMetricsUILayer.Helpers
{
    public static class Gateway
    {
        public static List<ProjectTask> GetAllTasks()
        {
            //using (var context = new PMDataContext())
            //{
            //    var taskService = new TaskService(new TaskRepository(context));
            //    return taskService.GetAll();
            //}
            return new List<ProjectTask>();
        }

        public static List<Team> GetAllTeams()
        {
            //using (var context = new PMDataContext())
            //{
            //    var taskService = new TeamService(new TeamRepository(context));
            //    return taskService.GetAll();
            //}

            return new List<Team>();
        }

        public static User ValidateUser(string userName, string password)
        {
            using (var context = new PMEntities())
            {
                var loginService = new LoginService(new Cognizant.Tools.ProjectMetrics.DataLayer.LoginRepository(context));
                return loginService.GetByCredential(userName, password);
            }
        }
    }
}
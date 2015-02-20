using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cognizant.Tools.ProjectMetrics.DataLayer;
using Cognizant.Tools.ProjectMetrics.BusinessService;
using Cognizant.Tools.ProjectMetrics.DataAccessContracts;
using Cognizant.Tools.ProjectMetrics.DomainLayer;

namespace Cognizant.Tools.ProjectMetrics.ProjectMetricsUILayer.Helpers
{
    public static class Gateway
    {
        public static List<TaskDetail> GetAllTasks()
        {
            using (var context = new PMDataContext())
            {
                    var taskService = new TaskService(new TaskRepository(context));
                    return taskService.GetAll();
            }
        }

        public static List<Team> GetAllTeams()
        {
            using (var context = new PMDataContext())
            {
                var taskService = new TeamService(new TeamRepository(context));
                return taskService.GetAll();
            }
        }

        public static User ValidateUser(string userName, string password)
        {
            using (var context = new PMDataContext())
            {
                var loginService = new LoginService(new LoginRepository(context));
                return loginService.GetByCredential(userName, password);
            }
        }
    }
}
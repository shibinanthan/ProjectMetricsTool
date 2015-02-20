using Cognizant.Tools.ProjectMetrics.BusinessService;
using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Tools.ProjectMetrics.DataAccessContracts;

namespace Cognizant.Tools.ProjectMetrics.BusinessService
{
    public class TaskService
    {
        ITaskRepository taskRepository = null;

        public TaskService(ITaskRepository TaskRepository)
        {
            this.taskRepository = TaskRepository;
        }

        public List<TaskDetail> GetAll()
        {
            return this.taskRepository.GetAll();
        }
        
        public void AddTask(string taskDescription, Guid prjId, Guid reqId, Guid processId, int empID,
                     DateTime plannedStartDate, DateTime plannedEndDate, DateTime actualStartDate, DateTime actualEndDate, int durationInDays, int effortsInHours,
                     TaskType taskType, StatusofTask tskStatus, string comments, Confirmation anyChangeInReq, string risk)
        {
            var taskDetals = this.taskRepository.GetByDetails(taskDescription, prjId, reqId);

            if (taskDetals == null)
            {
                //this.taskRepository.Insert(new TaskDetail(taskDescription, prjId, reqId, processId, empID,
                //         plannedStartDate, plannedEndDate, actualStartDate, actualEndDate, durationInDays, effortsInHours,
                //         taskType, tskStatus, comments, anyChangeInReq, risk));

                this.taskRepository.Commit();
            }
        }

        public List<EmployeeReport> GetEmployeesReportByProject(List<int> empIds, Guid prjId)
        {
            var employeeReports = new List<EmployeeReport>();
            var dbReports = taskRepository.GetEmployeesReportByProject(empIds, prjId);
            
            // do business logic if any and populate EmployeeReport with respective fields

            return employeeReports;
        }

        public List<ProductivityReport> CalculateEmployeeProductivity(List<int> empIds, Guid prjId)
        {
            var rep = new List<ProductivityReport>();
            var dbReports = taskRepository.CalculateEmployeeProductivity(empIds, prjId);

            // do business logic if any and populate ProductivityReportReport with respective fields

            return rep;
        }

         public List<EmployeeReport> GetEmployeesReport(List<int> empIds)
        {
            // fetch appropriate records from taskRepository
            // do business logic if any and populate EmployeeReport with respective fields
            // return response
            throw new NotImplementedException();
        }

         public List<EmployeeReport> GetEmployeesReportByTime(List<int> empIds, DateTime actualStartDate, DateTime actualEndDate)
        {
            // fetch appropriate records from taskRepository
            // do business logic if any and populate EmployeeReport with respective fields
            // return response
            throw new NotImplementedException();
        }

        public List<ProjectReport> GetProjectWiseReport(List<Guid> prjIds)
        {
            // fetch appropriate records from taskRepository
            // do business logic if any and populate ProjectReport with respective fields
            // return response
            throw new NotImplementedException();
        }
    }
}

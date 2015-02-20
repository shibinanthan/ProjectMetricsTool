using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DataAccessContracts
{
    public interface ITaskRepository
    {
        List<TaskDetail> GetAll();
        void Insert(TaskDetail task);
        TaskDetail GetByDetails(string taskDescription, Guid prjId, Guid reqId);
        List<TaskDetail> GetEmployeesReportByProject(List<int> empIds, Guid prjId);
        List<TaskDetail> CalculateEmployeeProductivity(List<int> empIds, Guid prjId);

        void Commit();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Tools.ProjectMetrics.DataLayer.PM_EDMX;

namespace Cognizant.Tools.ProjectMetrics.DataAccessContracts
{
    public interface ITaskRepository
    {
        List<ProjectTask> GetAll();
        void Insert(ProjectTask task);
        ProjectTask GetByDetails(string taskDescription, Guid prjId, Guid reqId);
        List<ProjectTask> GetEmployeesReportByProject(List<int> empIds, Guid prjId);
        List<ProjectTask> CalculateEmployeeProductivity(List<int> empIds, Guid prjId);

        void Commit();

    }
}

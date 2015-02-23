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
        List<Tasks> GetAll();
        void Insert(Tasks task);
        Tasks GetByDetails(string taskDescription, Guid prjId, Guid reqId);
        List<Tasks> GetEmployeesReportByProject(List<int> empIds, Guid prjId);
        List<Tasks> CalculateEmployeeProductivity(List<int> empIds, Guid prjId);

        void Commit();

    }
}

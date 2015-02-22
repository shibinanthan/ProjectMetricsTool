using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Tools.ProjectMetrics.DataLayer.PM_EDMX;


namespace Cognizant.Tools.ProjectMetrics.DataAccessContracts
{
    public interface IProcessRepository
    {
        List<Process> GetAll();
        void Insert(Process Process);
        Phase GetByDetails(string processName, Guid phaseId, Guid activityId);
        void Commit();
    }
}

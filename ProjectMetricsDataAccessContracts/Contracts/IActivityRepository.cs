using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DataAccessContracts
{
    public interface IActivityRepository
    {
        List<Activity> GetAll();
        void Insert(Activity activity);
        Activity GetByDetails(string actvityName, Guid phaseId);
        void Commit();
    }
}

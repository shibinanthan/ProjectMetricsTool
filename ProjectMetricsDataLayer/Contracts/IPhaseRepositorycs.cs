using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Tools.ProjectMetrics.DataLayer.PM_EDMX;

namespace Cognizant.Tools.ProjectMetrics.DataAccessContracts
{
    public interface IPhaseRepository
    {
        List<Phase> GetAll();
        void Insert(Phase phase);
        Phase GetByName(string phaseName);
        void Commit();
    }
}

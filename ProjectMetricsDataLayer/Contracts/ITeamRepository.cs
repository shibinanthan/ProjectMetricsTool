using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Tools.ProjectMetrics.DataLayer.PM_EDMX;

namespace Cognizant.Tools.ProjectMetrics.DataAccessContracts
{
   public interface ITeamRepository
    {
        Team GetById(Guid id);

        List<Team> GetAll();

        void Insert(Team release);

        Team GetByName(string teamName);
        void Commit();
    }
}

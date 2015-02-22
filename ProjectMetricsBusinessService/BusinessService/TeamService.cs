using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Tools.ProjectMetrics.DataAccessContracts;
using Cognizant.Tools.ProjectMetrics.DataLayer.PM_EDMX;

namespace Cognizant.Tools.ProjectMetrics.BusinessService
{
    public class TeamService
    {
        ITeamRepository teamRepository = null;
        public TeamService(ITeamRepository teamRepository)
        {
            this.teamRepository = teamRepository;
        }

        public void AddTeam(string teamName)
        {
            var existDetails = teamRepository.GetByName(teamName);

            if (existDetails == null)
            {
                teamRepository.Insert(new Team() { Name = teamName });
                teamRepository.Commit();
            }
        }

        public List<Team> GetAll()
        {
            return this.teamRepository.GetAll();
        }
    }
}

using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Tools.ProjectMetrics.DataAccessContracts;

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
                //teamRepository.Insert(new Team(teamName));
                teamRepository.Commit();
            }
        }

        public List<Team> GetAll()
        {
            return this.teamRepository.GetAll();
        }
    }
}

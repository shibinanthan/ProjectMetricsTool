using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Tools.ProjectMetrics.DomainLayer;
using Cognizant.Tools.ProjectMetrics.DataAccessContracts;

namespace Cognizant.Tools.ProjectMetrics.BusinessService
{
    public class ProjectService
    {
        IProjectRepository projRepository = null;
        IReleaseRepository releaseRepository = null;
        ITeamRepository teamRepository = null;

        public ProjectService(IProjectRepository projRepository, IReleaseRepository releaseRepository
            , ITeamRepository teamRepository)
        {
            this.projRepository = projRepository;
            this.releaseRepository = releaseRepository;
            this.teamRepository = teamRepository;
        }

        public void AddProject(string projectId, string prjDesc, string releaseDesc, string teamName)
        {
            var release = releaseRepository.GetByDescription(releaseDesc);

            if (release == null)
            {
                releaseRepository.Insert(new Release(releaseDesc));
                releaseRepository.Commit();
            }

            var team = teamRepository.GetByName(teamName);

            if (team == null)
            {
                //this.teamRepository.Insert(new Team(teamName));
                this.teamRepository.Commit();
            }

            var project = this.projRepository.GetByDetails(projectId, prjDesc, release, team);

            if (project == null)
            {
                release = releaseRepository.GetByDescription(releaseDesc);
                team = teamRepository.GetByName(teamName);
                this.projRepository.Insert(new Project(projectId, prjDesc, release.ID, team.ID));
                this.projRepository.Commit();
            }
        }

        public Project GetProject(string projectId, string prjDesc, string releaseDesc, string teamName)
        {
            var release = releaseRepository.GetByDescription(releaseDesc);
            var team = teamRepository.GetByName(teamName);
            return this.projRepository.GetByDetails(projectId, prjDesc, release, team);
        }
    }
}

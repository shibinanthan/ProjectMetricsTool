using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Tools.ProjectMetrics.DataAccessContracts;

namespace Cognizant.Tools.ProjectMetrics.BusinessService
{

    public class RequirementService
    {
        IProjectRepository projRepository = null;
        IReleaseRepository releaseRepository = null;
        ITeamRepository teamRepository = null;
        IRequirementRepository reqRepository = null;

        public RequirementService(IProjectRepository projRepository, IReleaseRepository releaseRepository
            , ITeamRepository teamRepository, IRequirementRepository reqRepository)
        {
            this.projRepository = projRepository;
            this.releaseRepository = releaseRepository;
            this.teamRepository = teamRepository;
            this.reqRepository = reqRepository;
        }

        public void AddRequirement(string teamName, string projectId, string prjDesc,
            string releaseDesc, string requirementDescription)
        {
            var prjService = new ProjectService(projRepository, releaseRepository, teamRepository);

            prjService.AddProject(projectId, prjDesc, releaseDesc, teamName);

            var project = prjService.GetProject(projectId, prjDesc, releaseDesc, teamName);

            var requirement = reqRepository.GetByDetails(project.ID, requirementDescription);

            if (requirement == null)
            {
                project = prjService.GetProject(projectId, prjDesc, releaseDesc, teamName);
                this.reqRepository.Insert(new Requirement(project.ID, requirementDescription));
                this.reqRepository.Commit();
            }
        }
    }
}

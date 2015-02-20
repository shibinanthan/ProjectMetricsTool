using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DataAccessContracts
{
    public interface IProjectRepository
    {
        Project GetById(Guid id);

        Project GetByDetails(string projectId, string prjDesc, Release existRelease, Team existTeam);
        List<Project> GetAll();

        void Insert(Project project);

        void Commit();

    }
}

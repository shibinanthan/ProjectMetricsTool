using Cognizant.Tools.ProjectMetrics.DataAccessContracts;
using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Cognizant.Tools.ProjectMetrics.DataLayer
{
    public class ProjectRepository : BaseRepository<Project>, IProjectRepository
    {
        PMDataContext pmDataContext = null;
        public ProjectRepository(PMDataContext pmDataContext)
            : base(pmDataContext)
        {
            if (pmDataContext == null)
                throw new Exception("pmDataContext is null");

            this.pmDataContext = pmDataContext;
        }

        public void Insert(Project project)
        {
            base.InsertOnCommit(project);
        }

        public List<Project> GetAll()
        {
            Table<Project> projects = base.GetTable;
            return projects.ToList();
        }

        public Project GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            base.SaveChanges();
        }

        public Project GetByDetails(string projectId, string prjDesc, Release existRelease, Team existTeam)
        {
            var project = (from p in base.GetTable
                           where p.ProjectID == projectId && p.Description == prjDesc && p.TeamID == existTeam.ID
                             && p.ReleaseID == existRelease.ID
                           select p).ToList().FirstOrDefault();

            return project;
        }

    }
}

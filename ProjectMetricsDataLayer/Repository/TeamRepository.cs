using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cognizant.Tools.ProjectMetrics.DataAccessContracts;
using System.Data.Linq;

namespace Cognizant.Tools.ProjectMetrics.DataLayer
{
    public class TeamRepository : BaseRepository<Team>, ITeamRepository
    {
        PM_EDMX.PMEntities pmDataContext = null;
        public TeamRepository(PM_EDMX.PMEntities pmDataContext)
            : base(pmDataContext)
        {
            if (pmDataContext == null)
                throw new Exception("pmDataContext is null");

            this.pmDataContext = pmDataContext;
        }

        public Team GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Team> GetAll()
        {
            var team = (from tm in base.GetTable select tm).ToList();

            return team;
        }

        public void Insert(Team release)
        {
            throw new NotImplementedException();
        }


        public Team GetByName(string teamName)
        {
            var team = (from tm in base.GetTable
                      where tm.Name == teamName
                      select tm).FirstOrDefault();

            return team;
        }
        public void Commit()
        {
            base.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System.Data.SqlClient;
using System.Data.Linq;
using Cognizant.Tools.ProjectMetrics.DataAccessContracts;

namespace Cognizant.Tools.ProjectMetrics.DataLayer
{
    public class RequirementRepository : BaseRepository<Requirement>, IRequirementRepository
    {

        PM_EDMX.PMEntities pmDataContext = null;
        public RequirementRepository(PM_EDMX.PMEntities pmDataContext)
            : base(pmDataContext)
        {
            if (pmDataContext == null)
                throw new Exception("pmDataContext is null");

            this.pmDataContext = pmDataContext;
        }

        public Requirement GetById(Guid prjId, Guid requiremntId)
        {
            throw new NotImplementedException();
        }

        public List<Requirement> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Requirement release)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            base.SaveChanges();
        }
        public Requirement GetByDetails(Guid prjId, string requiremntDescription)
        {
            var req = (from r in base.GetTable
                       where r.ID == prjId && r.Description == requiremntDescription
                       select r).FirstOrDefault();

            return req;
        }
    }
}

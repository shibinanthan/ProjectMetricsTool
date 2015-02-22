using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Linq;
using Cognizant.Tools.ProjectMetrics.DataAccessContracts;

namespace Cognizant.Tools.ProjectMetrics.DataLayer
{
    public class ReleaseRepository : BaseRepository<Release>, IReleaseRepository
    {
        PM_EDMX.PMEntities pmDataContext = null;
        public ReleaseRepository(PM_EDMX.PMEntities pmDataContext)
            : base(pmDataContext)
        {
            if (pmDataContext == null)
                throw new Exception("pmDataContext is null");

            this.pmDataContext = pmDataContext;
        }

        public Release GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Release> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Release release)
        {
            base.InsertOnCommit(release);
        }

        public Release GetByDescription(string releaseDesc)
        {
            var release = (from rel in pmDataContext.GetTable<Release>()
                        where rel.Description == releaseDesc
                        select rel).FirstOrDefault();

            return release;
        }

        public void Commit()
        {
            base.SaveChanges();
        }

    }
}

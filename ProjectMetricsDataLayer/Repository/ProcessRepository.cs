using System;
using System.Collections.Generic;
using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Linq;
using Cognizant.Tools.ProjectMetrics.DataAccessContracts;

namespace Cognizant.Tools.ProjectMetrics.DataLayer
{
    public class ProcessRepository : BaseRepository<Process>, IProcessRepository
    {

        PM_EDMX.PMEntities pmDataContext = null;
        public ProcessRepository(PM_EDMX.PMEntities pmDataContext)
            : base(pmDataContext)
        {
            if (pmDataContext == null)
                throw new Exception("pmDataContext is null");

            this.pmDataContext = pmDataContext;
        }
        public List<Process> GetAll()
        {
            return base.GetTable.ToList();
        }

        public void Commit()
        {
            base.SaveChanges();
        }

        public void Insert(Process Process)
        {
            throw new NotImplementedException();
        }

        public Phase GetByDetails(string phaseName, Guid phaseId, Guid activityId)
        {
            throw new NotImplementedException();
        }
    }
}

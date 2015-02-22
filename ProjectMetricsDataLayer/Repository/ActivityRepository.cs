using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Tools.ProjectMetrics.DataAccessContracts;

namespace Cognizant.Tools.ProjectMetrics.DataLayer
{
    public class ActivityRepository : BaseRepository<Activity> , IActivityRepository
    {

        PM_EDMX.PMEntities pmDataContext = null;
        public ActivityRepository(PM_EDMX.PMEntities pmDataContext)
            : base(pmDataContext)
        {
            if (pmDataContext == null)
                throw new Exception("pmDataContext is null");

            this.pmDataContext = pmDataContext;

        }
        public List<Activity> GetAll()
        {
            return base.GetTable.ToList();
        }

        public void Commit()
        {
            base.SaveChanges();
        }

        public void Insert(Activity activity)
        {
            throw new NotImplementedException();
        }

        public Activity GetByDetails(string phaseName, Guid phaseId)
        {
            throw new NotImplementedException();
        }
    }
}

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
    public class PhaseRepository : BaseRepository<Phase>, IPhaseRepository
    {
        PMDataContext pmDataContext = null;
        public PhaseRepository(PMDataContext pmDataContext)
            : base(pmDataContext)
        {
            if (pmDataContext == null)
                throw new Exception("pmDataContext is null");

            this.pmDataContext = pmDataContext;
        }

        public List<Phase> GetAll()
        {
            return base.GetTable.ToList();
        }

        public void Commit()
        {
            base.SaveChanges();
        }

        public void Insert(Phase phase)
        {
            throw new NotImplementedException();
        }

        public Phase GetByName(string phaseName)
        {
            throw new NotImplementedException();
        }
    }
}

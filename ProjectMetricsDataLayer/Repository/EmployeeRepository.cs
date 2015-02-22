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
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        PM_EDMX.PMEntities pmDataContext = null;
        public EmployeeRepository(PM_EDMX.PMEntities pmDataContext)
            : base(pmDataContext)
        {
            if (pmDataContext == null)
                throw new Exception("pmDataContext is null");

            this.pmDataContext = pmDataContext;
        }

        public Employee GetById(int empId)
        {
            var emp = (from e in base.GetTable
                           where e.EmpID == empId
                           select e).FirstOrDefault();

            return emp;
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            base.SaveChanges();
        }
    }
}

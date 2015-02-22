using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Tools.ProjectMetrics.DataLayer.PM_EDMX;

namespace Cognizant.Tools.ProjectMetrics.DataAccessContracts
{
    public interface IEmployeeRepository
    {
        Employee GetById(int empId);

        List<Employee> GetAll();

        void Insert(Employee employee);

        void Commit();
    }
}

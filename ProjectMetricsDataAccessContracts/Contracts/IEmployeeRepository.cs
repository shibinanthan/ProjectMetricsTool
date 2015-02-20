using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

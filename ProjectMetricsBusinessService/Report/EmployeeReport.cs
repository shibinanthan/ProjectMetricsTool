using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.BusinessService
{
    public class EmployeeReport : Report
    {
        public List<Employee> Employees { get; private set; }
    }
}

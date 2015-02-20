using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DomainLayer
{
    [Table]
    public class Employee
    {
        private int empId;
        private string empName;
        private Guid guid;

        public int EmpID { get; private set; }
        [Column]
        public string Name { get; private set; }
        [Column]
        public Guid TeamID { get; private set; }

        public Employee(int empID, string empName, Guid teamID)
        {
            EmpID = empID;
            Name = empName;
            TeamID = teamID;
        }

    }
}

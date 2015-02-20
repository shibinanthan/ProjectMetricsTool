using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Tools.ProjectMetrics.DataAccessContracts;

namespace Cognizant.Tools.ProjectMetrics.BusinessService
{
    public class EmployeeService
    {
        IEmployeeRepository empRepository = null;
        ITeamRepository teamRepository = null;
        public EmployeeService(IEmployeeRepository empRepository, ITeamRepository teamRepository)
        {
            this.empRepository = empRepository;
            this.teamRepository = teamRepository;
        }

        public void AddEmployee(string empName, int empId, string teamName)
        {
            var team = teamRepository.GetByName(teamName);

            if (team == null)
            {
                //teamRepository.Insert(new Team(teamName));
                teamRepository.Commit();
            }

            var emp = empRepository.GetById(empId);

            if (team == null)
            {
                team = teamRepository.GetByName(teamName);
                empRepository.Insert(new Employee(empId, empName, team.ID));
                teamRepository.Commit();
            }
        }
    }
}
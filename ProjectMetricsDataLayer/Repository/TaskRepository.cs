using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cognizant.Tools.ProjectMetrics.DataAccessContracts;
using System.Data.Linq;

namespace Cognizant.Tools.ProjectMetrics.DataLayer
{
    public class TaskRepository : BaseRepository<TaskDetail>, ITaskRepository
    {
        PMDataContext pmDataContext = null;
        public TaskRepository(PMDataContext pmDataContext)
            : base(pmDataContext)
        {
            if (pmDataContext == null)
                throw new Exception("pmDataContext is null");

            this.pmDataContext = pmDataContext;
        }
        public List<TaskDetail> GetAll()
        {
            var task = (from t in base.GetTable select t).ToList();

            return task;
        }

        public void Insert(TaskDetail task)
        {
            base.InsertOnCommit(task);
        }

        public void Commit()
        {
            base.SaveChanges();
        }

        public TaskDetail GetByDetails(string taskDescription, Guid prjId, Guid reqId)
        {
            var task = (from t in base.GetTable
                        where t.PrjID == prjId && t.ReqID == reqId && t.Description == taskDescription
                        select t).FirstOrDefault();

            return task;
        }


        public List<TaskDetail> GetEmployeesReportByProject(List<int> empIds, Guid prjId)
        {
            var results = (from t in base.GetTable
                           where empIds.Contains(t.EmpID) && t.PrjID == prjId
                           select t).ToList();

            return results;
        }

        

        public List<TaskDetail> CalculateEmployeeProductivity(List<int> empIds, Guid prjId)
        {
            throw new NotImplementedException();
        }
    }
}

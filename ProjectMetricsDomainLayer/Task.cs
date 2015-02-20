using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DomainLayer
{
    public class Task : Entity
    {
        public string Description { get; private set; } 
        public int ReqID { get; private set; }
        public int ProcessID { get; private set; }
        public int EmpID { get; private set; }
        public DateTime PlannedStartDate { get; private set; }
        public DateTime PlannedEndDate { get; private set; }
        public DateTime ActualStartDate { get; private set; }
        public DateTime ActualEndDate { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime UpdatedDate { get; private set; }
        public float TotalDuration { get; private set; }
        public float TotalEffort { get; private set; }
        public TaskType TaskType { get; private set; }
        public int Priority { get; private set; }
        public TaskStatus TaskStatus { get; private set; }
        public string Allocation { get; private set; }
        public string Comments { get; private set; }
        public Confirmation AnyChangeInReq { get; private set; }
        public Confirmation Risk { get; private set; }
    }
}

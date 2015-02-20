using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DomainLayer
{
    [Table]
    public class TaskDetail
    {
        private DateTime? plannedStartDate;
        private DateTime? plannedEndDate;
        private DateTime? actualStartDate;
        private DateTime? actualEndDate;

        //[Column(IsDbGenerated = true)]
        //public Guid ID { get; private set; }
        [Column]
        public string Description { get; private set; }
        [Column]
        public Guid PrjID { get; private set; }
        [Column]
        public Guid ReleaseID { get; private set; }
        [Column]
        public Guid ReqID { get; private set; }
        [Column]
        public Guid ProcessID { get; private set; }
        [Column]
        public int EmpID { get; private set; }
        [Column]
        public DateTime? PlannedStartDate
        {
            get
            {
                return plannedStartDate;
            }
            private set
            {
                if (plannedEndDate != null && (plannedStartDate > plannedEndDate))
                    throw new Exception("PlannedStartDate should not be greater than PlannedEndDate");
                plannedStartDate = value;
            }
        }
        [Column]
        public DateTime? PlannedEndDate
        {
            get
            {
                return plannedEndDate;
            }
            private set
            {
                if (plannedStartDate != null && (plannedEndDate < plannedStartDate))
                    throw new Exception("PlannedEndDate should not be lessar than PlannedStartDate");
                plannedEndDate = value;
            }
        }

        [Column]
        public DateTime? ActualStartDate
        {
            get
            {
                return actualStartDate;
            }
            private set
            {
                if ((actualEndDate != null && actualStartDate > actualEndDate))
                    throw new Exception("ActualStartDate should not be greater than ActualEndDate");
                actualStartDate = value;
            }
        }
        [Column]
        public DateTime? ActualEndDate
        {
            get
            {
                return actualEndDate;
            }
            private set
            {
                if (actualStartDate != null && (actualEndDate < actualStartDate))
                    throw new Exception("ActualEndDate should not be lessar than ActualStartDate");
                actualEndDate = value;
            }
        }
        [Column]
        public DateTime CreatedDate { get; private set; }
        [Column]
        public DateTime UpdatedDate { get; private set; }
        [Column]
        public float TotalDuration { get; private set; }
        [Column]
        public float TotalEffort { get; private set; }
        [Column]
        public TaskType TaskType { get; private set; }
        [Column]
        public int Priority { get; private set; }
        [Column]
        public StatusofTask StatusofTask { get; private set; }
        [Column]
        public string Allocation { get; private set; }
        [Column]
        public string Comments { get; private set; }
        [Column]
        public Confirmation AnyChangeInReq { get; private set; }
        [Column]
        public string Risk { get; private set; }

        //public TaskDetail(string taskDescription, Guid prjId, Guid releaseId, Guid reqId, Guid processId, int empID,
        //            DateTime? plannedStartDate, DateTime? plannedEndDate, DateTime? actualStartDate, DateTime? actualEndDate, int durationInDays, int effortsInHours,
        //            TaskType taskType, StatusofTask tskStatus, string comments, Confirmation anyChangeInReq, string risk)
        //{
        //    Description = taskDescription;
        //    PrjID = prjId;
        //    ReleaseID = releaseId;
        //    ReqID = reqId;
        //    ProcessID = processId;
        //    EmpID = empID;
        //    PlannedStartDate = plannedStartDate;
        //    PlannedEndDate = plannedEndDate;
        //    ActualStartDate = actualStartDate;
        //    ActualEndDate = actualEndDate;
        //    CreatedDate = DateTime.Now;
        //    TotalDuration = durationInDays;
        //    TotalEffort = effortsInHours;
        //    TaskType = taskType;
        //    StatusofTask = tskStatus;
        //    Comments = comments;
        //    AnyChangeInReq = anyChangeInReq;
        //    Risk = risk;
        //}

        //public TaskDetail(string taskDescription, Guid prjId, Guid reqId, Guid processId, int empID, DateTime plannedStartDate, DateTime plannedEndDate, DateTime actualStartDate, DateTime actualEndDate, int durationInDays, int effortsInHours, DomainLayer.TaskType taskType, DomainLayer.StatusofTask tskStatus, string comments, Confirmation anyChangeInReq, string risk)
        //{
        //    Description = taskDescription;
        //    PrjID = prjId;
        //    ReqID = reqId;
        //    ProcessID = processId;
        //    EmpID = empID;
        //    PlannedStartDate = plannedStartDate;
        //    PlannedEndDate = plannedEndDate;
        //    ActualStartDate = actualStartDate;
        //    ActualEndDate = actualEndDate;
        //    CreatedDate = DateTime.Now;
        //    TotalDuration = durationInDays;
        //    TotalEffort = effortsInHours;
        //    TaskType = taskType;
        //    StatusofTask = tskStatus;
        //    Comments = comments;
        //    AnyChangeInReq = anyChangeInReq;
        //    Risk = risk;
        //}
    }
}

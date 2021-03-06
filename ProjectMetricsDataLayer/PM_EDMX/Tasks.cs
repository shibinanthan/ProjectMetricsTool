//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cognizant.Tools.ProjectMetrics.DataLayer.PM_EDMX
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tasks
    {
        public System.Guid TaskID { get; set; }
        public string Description { get; set; }
        public System.Guid PrjID { get; set; }
        public System.Guid ReqID { get; set; }
        public System.Guid ProcessID { get; set; }
        public int EmpID { get; set; }
        public Nullable<System.DateTime> PlannedStartDate { get; set; }
        public Nullable<System.DateTime> PlannedEndDate { get; set; }
        public Nullable<System.DateTime> ActualStartDate { get; set; }
        public Nullable<System.DateTime> ActualEndDate { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public decimal TotalDuration { get; set; }
        public decimal TotalEffort { get; set; }
        public string TaskType { get; set; }
        public string Priority { get; set; }
        public string TaskStatus { get; set; }
        public string Allocation { get; set; }
        public string Comments { get; set; }
        public Nullable<bool> AnyChangeInReq { get; set; }
        public string Risk { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Process Process { get; set; }
        public virtual Project Project { get; set; }
        public virtual Requirement Requirement { get; set; }
    }
}

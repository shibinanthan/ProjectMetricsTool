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
    
    public partial class Process
    {
        public Process()
        {
            this.Tasks = new HashSet<Tasks>();
        }
    
        public System.Guid ProcessID { get; set; }
        public System.Guid ActivityID { get; set; }
        public string Description { get; set; }
    
        public virtual Activity Activity { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; }
    }
}

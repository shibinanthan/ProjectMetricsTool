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
    
    public partial class Phase
    {
        public Phase()
        {
            this.Activities = new HashSet<Activity>();
        }
    
        public System.Guid PhaseID { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Activity> Activities { get; set; }
    }
}

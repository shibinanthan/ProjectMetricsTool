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
    
    public partial class Team
    {
        public Team()
        {
            this.Employees = new HashSet<Employee>();
            this.Projects = new HashSet<Project>();
        }
    
        public System.Guid TeamID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}


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
    
public partial class Activity
{

    public Activity()
    {

        this.Processes = new HashSet<Process>();

    }


    public System.Guid ActivityID { get; set; }

    public System.Guid PhaseID { get; set; }

    public string Description { get; set; }



    public virtual Phase Phase { get; set; }

    public virtual ICollection<Process> Processes { get; set; }

}

}

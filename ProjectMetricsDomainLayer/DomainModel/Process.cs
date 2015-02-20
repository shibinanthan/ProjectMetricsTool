using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DomainLayer
{
    [Table]
    public class Process
    {
        [Column(IsDbGenerated = true)]
        public Guid ID { get; private set; }
        [Column]
        public Guid PhaseID { get; private set; }
        [Column]
        public Guid ActivityID { get; private set; }
        [Column]
        public string Description { get; private set; }


        public Process(string desc, Guid phaseId, Guid activityID)
        {
            PhaseID = phaseId;
            Description = desc;
            ActivityID = activityID;
        }
    }
}

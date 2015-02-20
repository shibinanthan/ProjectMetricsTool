using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DomainLayer
{
    [Table]
    public class Activity
    {
        [Column(IsDbGenerated = true)]
        public Guid ID { get; private set; }
        [Column]
        public Guid PhaseID { get; private set; }
        [Column]
        public string Description { get; private set; }

        public Activity(string desc, Guid phaseId)
        {
            PhaseID = phaseId;
            Description = desc;
        }
    }
}

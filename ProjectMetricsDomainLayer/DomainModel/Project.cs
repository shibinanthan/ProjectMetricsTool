using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DomainLayer
{
    [Table]
    public class Project
    {
        [Column(IsDbGenerated=true)]
        public Guid ID { get; private set; }

        [Column]
        public string ProjectID { get; private set; }

        [Column]
        public Guid TeamID { get; private set; }

        [Column]
        public string Description { get; private set; }

        [Column]
        public Guid ReleaseID { get; private set; }

        public Project(string projectId, string projectDescription, Guid releaseID, Guid teamID)
        {
            ProjectID = projectId;
            Description = projectDescription;
            ReleaseID = releaseID;
            TeamID = teamID;
        }
    }
}

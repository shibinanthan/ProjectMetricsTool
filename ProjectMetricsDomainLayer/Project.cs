using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DomainLayer
{
    public class Project : Entity
    {
        public string ProjectID { get; private set; }
        public string Description { get; private set; }
        public Release Release { get; private set; }

        public Project(string projectId, string projectDescription, string releaseDescription)
        {
            ProjectID = projectId;
            Description = projectDescription;
            this.Release = new Release(releaseDescription);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DomainLayer
{
    public class Release : Entity
    {
        public int ProjectID { get; private set; }
        public string Description { get; private set; }

        public Release(string releaseDescription)
        {
            this.Description = releaseDescription;
        }
    }
}

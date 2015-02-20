using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DomainLayer
{
    public class Activity : Entity
    {
        public int PhaseID { get; private set; }
        public string Description { get; private set; }
    }
}

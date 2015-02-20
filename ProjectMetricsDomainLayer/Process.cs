using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DomainLayer
{
    public class Process : Entity
    {
        public int PhaseID { get; private set; }
        public int ActivityID { get; private set; }
        public string Description { get; private set; }
    }
}

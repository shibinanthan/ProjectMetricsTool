using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DomainLayer
{
    public class Employee : Entity
    {
        public string Name { get; private set; }
        public int TeamID { get; private set; }
    }
}

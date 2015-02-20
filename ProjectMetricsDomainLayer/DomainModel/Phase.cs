using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DomainLayer
{
    [Table]
    public class Phase
    {
        [Column(IsDbGenerated = true)]
        public Guid ID { get; private set; }
        [Column]
        public string Description { get; private set; }

        public Phase(string desc)
        {
            Description = desc;
        }
    }
}

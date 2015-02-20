using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DomainLayer
{
    [Table]
    public class Release
    {
        [Column(IsDbGenerated = true)]
        public Guid ID { get; private set; }
        [Column]
        public string Description { get; private set; }

        public Release(string desc)
        {
            Description = desc;
        }
    }
}

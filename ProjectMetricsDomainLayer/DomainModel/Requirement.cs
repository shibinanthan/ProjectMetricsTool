using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DomainLayer
{
    [Table]
    public class Requirement
    {
        [Column(IsDbGenerated = true)]
        public Guid ID { get; private set; }
        [Column]
        public Guid PrjID { get; private set; }
        [Column]
        public string Description { get; private set; }

        public Requirement(Guid prjId, string description)
        {
            PrjID = prjId;
            Description = description;
        }

    }
}

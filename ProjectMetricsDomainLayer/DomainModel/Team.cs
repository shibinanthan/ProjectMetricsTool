using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DomainLayer
{
    [Table]
    public class Team
    {
        [Column(IsDbGenerated = true)]
        public Guid ID { get; private set; }

        [Column]
        public string Name { get; private set; }

        //public Team(string teamName)
        //{
        //    Name = teamName;
        //}

    }
}

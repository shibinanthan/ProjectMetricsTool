using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Cognizant.Tools.ProjectMetrics.DataLayer.PM_EDMX
{
    public partial class PMEntities : DbContext
    {
        public PMEntities(string ConnectionString)
            : base(ConnectionString)
        {
        }
    }
}

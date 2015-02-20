using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DataLayer
{
    /// <summary>
    /// Null Object pattern
    /// </summary>
    public class NullCacheService : ICacheService
    {
        public object Get(string key)
        { 
            // Do Nothing;
            return new object();
        }

        public void Insert(string key, object value)
        {
           // Do Nothing;
        }

        public void Remove(string key)
        {
           // Do Nothing;
        }

        public void Update(string key, object value)
        {
           // Do Nothing;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DataLayer
{
    /// <summary>
    /// Implement Http context cache , if applciation uses Asp.net framework in UI
    /// </summary>
    public class HTTPCacheService : ICacheService
    {
        public object Get(string key)
        {
            throw new NotImplementedException();
        }

        public void Insert(string key, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(string key)
        {
            throw new NotImplementedException();
        }

        public void Update(string key, object value)
        {
            throw new NotImplementedException();
        }
    }
}

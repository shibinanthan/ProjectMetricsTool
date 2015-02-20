using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DataLayer
{
    public interface ICacheService
    {
        object Get(string key);
        void Insert(string key, object value);
        void Remove(string key);
        void Update(string key, object value);
    }
}

using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DataAccessContracts
{
    public interface ILoginRepository
    {
        List<PM_EDMX.User> GetAll();
        User GetByCredential(string userName, string passsword);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Tools.ProjectMetrics.DataAccessContracts;
using Cognizant.Tools.ProjectMetrics.DataLayer.PM_EDMX;
using Cognizant.Tools.ProjectMetrics.DataLayer;

namespace Cognizant.Tools.ProjectMetrics.BusinessService
{
    public class LoginService
    {
        private LoginRepository objLoginRepository = null;

        public LoginService()
        {
            if (objLoginRepository == null)
                objLoginRepository = new LoginRepository();
        }

        public List<User> GetAll()
        {
            return objLoginRepository.GetAll();
            
        }

        public User GetByCredential(string userName, string password)
        {
            return objLoginRepository.GetByCredential(userName, password);
        }
    }
}

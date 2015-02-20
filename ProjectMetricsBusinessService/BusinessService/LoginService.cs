using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Tools.ProjectMetrics.DataAccessContracts;


namespace Cognizant.Tools.ProjectMetrics.BusinessService
{
    public class LoginService
    {
        ILoginRepository loginRepository = null;
        public LoginService(ILoginRepository loginRepository)
        {
            this.loginRepository = loginRepository;
        }

        public List<User> GetAll()
        {
            return this.loginRepository.GetAll();
        }

        public User GetByCredential(string userName, string password)
        {
            return this.loginRepository.GetByCredential(userName, password);
        }
    }
}

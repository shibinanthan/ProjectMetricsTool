using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cognizant.Tools.ProjectMetrics.DataLayer.PM_EDMX;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cognizant.Tools.ProjectMetrics.DataAccessContracts;
using Cognizant.Tools.ProjectMetrics.ConnectionManager;
using System.Data.Linq;

namespace Cognizant.Tools.ProjectMetrics.DataLayer
{
    public class LoginRepository : ILoginRepository
    {
        private string internalConnection = string.Empty;

        public LoginRepository()
        {
            internalConnection = ConnectionManager.ConnectionManager.PMToolsEntityConnectionString.ToString();
        }

        public List<User> GetAll()
        {
            using (var context = new PMEntities(internalConnection))
            {
                var usersList = (from users in context.Users select users).ToList();
                return usersList;
            }
        }

        public User GetByCredential(string userName, string password)
        {
            using (var context = new PMEntities(internalConnection))
            {
                var userDetails = context.Users.Where(user => user.Name == userName && user.Password == password).FirstOrDefault();
                return userDetails;
            }
        }
    }
}

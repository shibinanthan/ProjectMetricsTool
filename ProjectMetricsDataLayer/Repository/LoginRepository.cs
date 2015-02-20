using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cognizant.Tools.ProjectMetrics.DataAccessContracts;
using System.Data.Linq;

namespace Cognizant.Tools.ProjectMetrics.DataLayer
{
    public class LoginRepository : BaseRepository<User>, ILoginRepository
    {
        //PMDataContext pmDataContext = null;
        //public LoginRepository(PMDataContext pmDataContext)
        //    : base(pmDataContext)
        //{
        //    if (pmDataContext == null)
        //        throw new Exception("pmDataContext is null");

        //    this.pmDataContext = pmDataContext;
        //}

        

        public List<User> GetAll()
        {
            var user = (from tm in base.GetTable select tm).ToList();

            return user;
        }

        public User GetByCredential(string userName, string password)
        {
            using (var context = new PM_EDMX.PMEntities())
            {
                var userDetails = context.Users.Where(user => user.Name == userName && user.Password == password).Select(user).FirstOrDefault();
                return userDetails;
            }
            
        }
    }
}

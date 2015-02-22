using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Cognizant.Tools.ProjectMetrics.DomainLayer;
using Cognizant.Tools.ProjectMetrics.DataLayer.PM_EDMX;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cognizant.Tools.ProjectMetrics.DataAccessContracts;
using System.Data.Linq;

namespace Cognizant.Tools.ProjectMetrics.DataLayer
{
    public class LoginRepository : BaseRepository<User>, ILoginRepository
    {
        PMEntities pmDataContext = null;
        public LoginRepository(PMEntities pmDataContext)
            : base(pmDataContext)
        {
            if (pmDataContext == null)
                throw new Exception("pmDataContext is null");

            this.pmDataContext = pmDataContext;
        }



        public List<User> GetAll()
        {
            //var user = (from tm in User select tm).ToList();

            return new List<User>();
        }

        public User GetByCredential(string userName, string password)
        {
            using (var db = new PMEntities())
            {
                var userDetails = db.Users.Where(i => i.Name == userName && i.Password == password).FirstOrDefault();
                return userDetails;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DataLayer
{
    public abstract class BaseRepository<TEntity> where TEntity : class
    {
        private PMDataContext _pmDataContext;

        protected BaseRepository(PMDataContext dataContext)
        {
            _pmDataContext = dataContext;
        }

        protected Table<TEntity> GetTable
        {
            get { return _pmDataContext.GetTable<TEntity>(); }
        }

        protected void InsertOnCommit(TEntity entity)
        {
            _pmDataContext.GetTable<TEntity>().InsertOnSubmit(entity);
        }

        protected void DeleteOnCommit(TEntity entity)
        {
            _pmDataContext.GetTable<TEntity>().DeleteOnSubmit(entity);
        }

        protected void SaveChanges()
        {
            _pmDataContext.SubmitChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Tools.ProjectMetrics.DataLayer.PM_EDMX;

namespace Cognizant.Tools.ProjectMetrics.DataAccessContracts
{
    public interface IReleaseRepository
    {
        Release GetById(Guid id);

        List<Release> GetAll();

        void Insert(Release release);

        Release GetByDescription(string releaseDesc);

        void Commit();

    }
}

using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Tools.ProjectMetrics.DataAccessContracts;

namespace Cognizant.Tools.ProjectMetrics.BusinessService
{
    public class ReleaseService
    {
        IReleaseRepository releaseRepository = null;
        public ReleaseService(IReleaseRepository releaseRepository)
        {
            this.releaseRepository = releaseRepository;
        }

        public void AddRelease(string releaseDesc)
        {
            var existDetails = releaseRepository.GetByDescription(releaseDesc);

            if (existDetails == null)
            {
                releaseRepository.Insert(new Release(releaseDesc));
                releaseRepository.Commit();
            }

        }
    }
}

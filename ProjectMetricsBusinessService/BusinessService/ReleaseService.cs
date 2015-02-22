﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Tools.ProjectMetrics.DataAccessContracts;
using Cognizant.Tools.ProjectMetrics.DataLayer.PM_EDMX;

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
                releaseRepository.Insert(new Release() { Description = releaseDesc });
                releaseRepository.Commit();
            }

        }
    }
}

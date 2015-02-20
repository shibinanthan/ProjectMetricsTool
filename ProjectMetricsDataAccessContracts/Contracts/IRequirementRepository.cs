﻿using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DataAccessContracts
{
    public interface IRequirementRepository
    {
        Requirement GetById(Guid prjId, Guid requiremntId);
        Requirement GetByDetails(Guid prjId, string requiremntDescription);

        List<Requirement> GetAll();

        void Insert(Requirement release);

        void Commit();
    }
}

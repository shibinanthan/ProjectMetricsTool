using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Tools.ProjectMetrics;
using Cognizant.Tools.ProjectMetrics.DataAccessContracts;

namespace Cognizant.Tools.ProjectMetrics.BusinessService
{

    public class ProcessDetails
    {
        static object lockContext = new object();
        private static ProcessDetails instance;

        public List<Phase> PhaseList { get; private set; }
        public List<Activity> ActivityList { get; private set; }
        public List<Process> ProcessList { get; private set; }

        private ProcessDetails(IPhaseRepository phaseRepository, IActivityRepository activityRepository, IProcessRepository processRepository)
        {
            PhaseList = phaseRepository.GetAll();
            ActivityList = activityRepository.GetAll();
            ProcessList = processRepository.GetAll();
        }

        public static ProcessDetails GetInstance(IPhaseRepository phaseRepository, IActivityRepository activityRepository, IProcessRepository processRepository)
        {
            lock (lockContext)
            {
                if (instance == null)
                {
                    instance = new ProcessDetails(phaseRepository, activityRepository, processRepository);
                }
                return instance;
            }
        }
    }
}
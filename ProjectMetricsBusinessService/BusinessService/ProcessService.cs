using Cognizant.Tools.ProjectMetrics.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Tools.ProjectMetrics.DataAccessContracts;

namespace Cognizant.Tools.ProjectMetrics.BusinessService
{
    public class ProcessService
    {
        IProcessRepository processRepository = null;
        IActivityRepository activityRepository = null;
        IPhaseRepository phaseRepository = null;
        public ProcessService(IProcessRepository processRepository, IActivityRepository activityRepository,
                    IPhaseRepository phaseRepository)
        {
            this.processRepository = processRepository;
            this.activityRepository = activityRepository;
            this.phaseRepository = phaseRepository;
        }

        public void AddProcess(string phaseName, string activityName, string processName)
        {
            var phase = phaseRepository.GetByName(phaseName);

            if (phase == null)
            {
                phaseRepository.Insert(new Phase(phaseName));
                phaseRepository.Commit();
                phase = phaseRepository.GetByName(phaseName);
            }

            var activity = activityRepository.GetByDetails(phaseName, phase.ID);

            if (activity == null)
            {
                activityRepository.Insert(new Activity(activityName, phase.ID));
                activityRepository.Commit();
                activity = activityRepository.GetByDetails(activityName, phase.ID);
            }

            var process = processRepository.GetByDetails(processName, phase.ID, activity.ID);

            if (process == null)
            {
                processRepository.Insert(new Process(processName, phase.ID, activity.ID));
                processRepository.Commit();
            }
        }
    }
}

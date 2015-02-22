using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Tools.ProjectMetrics.DataAccessContracts;
using Cognizant.Tools.ProjectMetrics.DataLayer.PM_EDMX;

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
                phaseRepository.Insert(new Phase() { Description = phaseName });
                phaseRepository.Commit();
                phase = phaseRepository.GetByName(phaseName);
            }

            var activity = activityRepository.GetByDetails(phaseName, phase.PhaseID);

            if (activity == null)
            {
                activityRepository.Insert(new Activity() { Description = activityName, PhaseID = phase.PhaseID });
                activityRepository.Commit();
                activity = activityRepository.GetByDetails(activityName, phase.PhaseID);
            }

            var process = processRepository.GetByDetails(processName, phase.PhaseID, activity.ActivityID);

            if (process == null)
            {
                processRepository.Insert(new Process() { Description = processName, ActivityID = activity.ActivityID });
                processRepository.Commit();
            }
        }
    }
}

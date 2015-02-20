using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DomainLayer
{
    public enum TaskStatus
    {
        Assigned,
        Started,
        InProgress,
        Completed,
        Cancelled
    }

    public enum TaskType
    {
        ProjectActivity,
        NonProjectActivity
    }

    public enum Confirmation
    {
        Yes,
        No
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cognizant.Tools.ProjectMetrics.ProjectMetricsUILayer.Models
{
    public class TaskModel
    {
        public TaskModel()
        {
            Teams = new List<SelectListItem>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [Display(Name = "Task Description")]
        public string Name { get; set; }

        public int AssignedToId { get; set; }
        [DisplayName("Assigned To")]
        public string AssignedToName { get; set; }
        public IEnumerable<SelectListItem> TeamMemebrs { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Planned Start Date")]
        [DefaultValue(false)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Planned End Date")]
        [DefaultValue(false)]
        public DateTime EndDate { get; set; }

        [Required]
        [Display(Name = "Planned Effort (hrs)")]
        [DefaultValue(false)]
        public decimal Effort { get; set; }

        [Required]
        [Display(Name = "Planned Duration (days)")]
        [DefaultValue(false)]
        public int Duration { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Created Date")]
        public DateTime CreationDate { get; set; }

        public int TaskTypeId { get; set; }
        [DisplayName("Task Type")]
        public string TaskTypeName { get; set; }
        public IEnumerable<SelectListItem> TaskType { get; set; }

        public int TeamId { get; set; }
        [DisplayName("Team")]
        public string TeamName { get; set; }
        public IEnumerable<SelectListItem> Teams { get; set; }
    }
}
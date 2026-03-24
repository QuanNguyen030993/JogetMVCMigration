using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using SurveyReportRE.Models.Migration.Base;
namespace SurveyReportRE.Models.Migration.Business.Workflow
{
    public class WorkflowInstanceNode : BaseModel
    {
        public Guid InstanceWorkflowId { get; set; }
        public Guid StepWorkflowId { get; set; }
        [MaxLength(50)]
        public string NodeStatus { get; set; } = "Pending"; // Pending / Active / Completed / Skipped / Returned
        public DateTime? ActivatedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int LoopCount { get; set; }
        [MaxLength(100)]
        public string? LastActionCode { get; set; } = "";

    }
}
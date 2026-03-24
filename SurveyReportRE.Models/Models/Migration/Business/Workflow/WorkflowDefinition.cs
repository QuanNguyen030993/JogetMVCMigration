using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using SurveyReportRE.Models.Migration.Base;
namespace SurveyReportRE.Models.Migration.Business.Workflow
{
    public class WorkflowDefinition : BaseModel
    {
        [MaxLength(8000)]
        public string WorkflowCode { get; set; } = null!;

        [MaxLength(255)]
        public string WorkflowName { get; set; } = null!;

        [MaxLength(100)]
        public string? FlowType { get; set; }   // Quotation / PolicyIssuance / Both

        public int VersionNo { get; set; } = 1;

        public bool IsActive { get; set; } = true;
        [MaxLength(8000)]
        public string? WorkflowNodes { get; set; } = "";
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using SurveyReportRE.Models.Migration.Base;
namespace SurveyReportRE.Models.Migration.Business.Workflow
{
    public class ActionWorkflow : BaseModel
    {
        [MaxLength(100)]
        public string ActionCode { get; set; } = null!;   // SEND_TO_TS / RETURN_TO_FO

        [MaxLength(1000)]
        public string ActionName { get; set; } = null!;

        public long? ActionCategoryId { get; set; }

        public bool RequireComment { get; set; }
        public bool RequireAttachment { get; set; }

        public bool IsSystemAction { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
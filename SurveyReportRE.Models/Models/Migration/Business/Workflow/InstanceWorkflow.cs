using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using SurveyReportRE.Models.Migration.Base;
namespace SurveyReportRE.Models.Migration.Business.Workflow
{
    public class InstanceWorkflow : BaseModel
    {
        public Guid? RecordGuid {get;set;}
        public int? CurrentStep {get;set;}
        public long? WorkflowStatusId {get;set;}
        public long? UserWorkflowId {get;set;}
        public long? RuleNo {get;set;} 
    }
}
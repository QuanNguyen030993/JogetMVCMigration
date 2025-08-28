using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using SurveyReportRE.Models.Migration.Base;
namespace SurveyReportRE.Models.Migration.Business.Workflow
{
    public class StepsWorkflow : BaseModel
    {
        public long? NotifyMailTemplateId {get;set;}
        public int? Steps {get;set;}
        public long? FlowMailTemplateId {get;set;}
        public long? ReturnMailTemplateId {get;set;}
        public long? ReturnId {get;set;}
        public long? PositiveStatusId {get;set;}
        public long? NegativeStatusId {get;set;}
        public string Entity {get;set;} = "";
    }
}
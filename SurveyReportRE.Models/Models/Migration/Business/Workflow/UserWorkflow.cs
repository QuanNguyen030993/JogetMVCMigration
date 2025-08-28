using System;
using System.ComponentModel.DataAnnotations;
using SurveyReportRE.Models.Migration.Base;
namespace SurveyReportRE.Models.Migration.Business.Workflow
{
    public class UserWorkflow : BaseModel
    {
        public long? UsersId {get;set;}
        public long? CheckerUsersId {get;set;}
        public long? ApproverUsersId {get;set;}
    }
}
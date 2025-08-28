using SurveyReportRE.Models.Migration.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SurveyReportRE.Models.Migration.Business.HumanResource
{
    public class Employee : BaseModel
    {
        [MaxLength(4000)]
        public string FirstName { get; set; } = "";
             [MaxLength(4000)]
        public string LastName { get; set; } = "";
             [MaxLength(4000)]
        public string FullName { get; set; } = "";
             [MaxLength(4000)]
        public string Department {get;set;} = "";
        
        public string AccountName {get;set;} = "";
             [MaxLength(4000)]
        public string Email {get;set;} = "";
        public long? ReportToUserId {get;set;}
        public long? UserId {get;set;}
        public long? AreaId {get;set;} 
        public long? SystemRoleId {get;set;}
        public long? SystemRolesId {get;set;}
        public string EmailName {get;set;} = "";
        public long?  UsersId {get;set;}
    }
}

using Microsoft.EntityFrameworkCore;
using SurveyReportRE.Models.Migration.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models.Migration.Config
{
    public class UserRoles : BaseModel
    {
         public long? RoleId {get;set;}
         public long? UserId {get;set;}
         public long? MenuId {get;set;}
    }
}

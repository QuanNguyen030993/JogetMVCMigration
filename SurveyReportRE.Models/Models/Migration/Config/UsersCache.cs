using Microsoft.EntityFrameworkCore;
using SurveyReportRE.Models.Migration.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace SurveyReportRE.Models.Migration.Config
{
    public class UsersCache : BaseModel
    {
        public long? UsersId {get ; set ; }
        [MaxLength(8000)]
        public string AccountName {get ; set ; } = "";
        [MaxLength(8000)]
        public string UsersCachePayLoad {get ; set ; } = "";
        public bool? ForceReloadCache {get ; set ; } = false;
        public bool? ForceReloadPage {get;set;} = false;
        public DateTime? ReloadCacheTime {get;set;} 
        public DateTime? ReloadPageTime {get;set;}
    }
}

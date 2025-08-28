using SurveyReportRE.Models.Migration.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SurveyReportRE.Models.Migration.Business.MasterData
{
    public class Wording : BaseModel
    {
        [MaxLength(4000)]
        public string WordingName { get; set; } = "";
        [MaxLength(8000)]
        public string WordingContent { get; set; } = "";
        [MaxLength(4000)]
        public string DefaultField {get;set;} = "";
        public long? DefaultFieldId {get;set;}
    }
}

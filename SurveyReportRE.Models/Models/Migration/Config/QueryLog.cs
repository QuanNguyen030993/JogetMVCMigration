using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurveyReportRE.Models.Migration.Base;

namespace SurveyReportRE.Models.Migration.Config
{
    public class QueryLog : BaseModel
    {
        [MaxLength(8000)]
        public string QueryString { get; set; } = "";
        [MaxLength(8000)]
        public string Duration { get; set; } = "";
        [MaxLength(8000)]
        public string User { get; set; } = "";
    }


}

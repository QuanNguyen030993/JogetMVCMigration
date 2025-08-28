using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurveyReportRE.Models.Migration.Base;

namespace SurveyReportRE.Models.Migration.Config
{
    public class ClientBrowserError : BaseModel
    {
        [MaxLength(8000)]
        public string Message { get; set; }         = "";
        [MaxLength(8000)]
        public string Url { get; set; }             = "";
        [MaxLength(8000)]
        public string UserAgent { get; set; }       = "";
        [MaxLength(8000)]
        public string ErrorDetails { get; set; }    = "";
        [MaxLength(8000)]
        public string Time { get; set; } = "";
    }


}

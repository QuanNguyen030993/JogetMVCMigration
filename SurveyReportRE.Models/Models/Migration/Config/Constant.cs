using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurveyReportRE.Models.Migration.Base;

namespace SurveyReportRE.Models.Migration.Config
{
    public class Constant : BaseModel
    {
        [MaxLength(8000)]
        public string ParameterName { get; set; }         = "";
        [MaxLength(8000)]
        public string Value { get; set; }             = "";
    }


}

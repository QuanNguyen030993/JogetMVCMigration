using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurveyReportRE.Models.Migration.Base;

namespace SurveyReportRE.Models.Migration.Business.MasterData
{
    public class Line : BaseModel
    {

        [MaxLength(255)]
        public string LineCode { get; set; } = "";

        [MaxLength(4000)]
        public string LineName { get; set; } = "";
        public bool IsActive { get; set; }
    }
}

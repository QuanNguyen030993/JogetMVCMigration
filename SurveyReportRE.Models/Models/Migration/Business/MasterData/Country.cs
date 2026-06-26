using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurveyReportRE.Models.Migration.Base;

namespace SurveyReportRE.Models.Migration.Business.MasterData
{
    public class Country : BaseModel
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public bool? IsActive { get; set; }
        [MaxLength(8000)]
        public string? Attributes { get; set; }
}
}

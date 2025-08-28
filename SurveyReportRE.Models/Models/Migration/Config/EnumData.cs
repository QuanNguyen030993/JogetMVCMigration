using Microsoft.EntityFrameworkCore;
using SurveyReportRE.Models.Migration.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models.Migration.Config
{
    public class EnumData : BaseModel
    {
        public long Value { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Key { get; set; } = "";
        public int? SysTableId { get; set; }
        public string SysTableName { get; set; } = "";
        public string MappingField { get; set; } = "";
        public int? EnumOrder {get;set; } =0;
    }
}

using Microsoft.EntityFrameworkCore;
using SurveyReportRE.Models.Migration.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models.Migration.Config
{
    public class FormatCodeNo : BaseModel
    {
            public string NoSeqCode {get;set;} = "";
            public int? Smallest {get;set;} = 0;
            public int? Largest {get;set;} = 0;
            public int? Next {get;set;} = 0;
            public string Format {get;set;} = "";
            public long? SysTableId {get;set;} 
            public string DateFormat {get;set;} = "";
            public bool? IsSysNum {get;set;} = false;
            public bool? IsDefault {get;set;} = false;
    }
}

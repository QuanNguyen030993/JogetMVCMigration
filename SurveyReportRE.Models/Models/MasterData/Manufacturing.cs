using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models
{
    public class Manufacturing : EntityBaseSysNo, IEntityBaseSysNo
    {
        public override int Id { get; set; }
        public int? ProductGroupId { get; set;}
        public SysEnumElement ProductGroup { get; set; }
        public DateTime ValidTo { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; } = true;
    }
}

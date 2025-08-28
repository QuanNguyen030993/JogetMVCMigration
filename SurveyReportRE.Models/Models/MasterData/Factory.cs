using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models
{
    public class Factory : EntityBaseSysNo, IEntityBaseSysNo
    {
        public override int Id { get; set; }
        public string MisaCode { get; set; }
        public string Note { get; set; }
        public bool? IsActive { get; set; } = true;
    }
}

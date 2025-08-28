using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Text;

namespace SurveyReportRE.Models
{
    public class ManufacturingCoefficient : EntityBase, IEntityBase
    {
        public override int Id { get; set; }
        public int? ManufacturingId { get; set; }
        public Manufacturing Manufacturing { get; set; }
        public string FixLocation { get; set; } = string.Empty;
        public double? WorkCoefficient { get; set; }
		public int? ProductGroupId { get; set; }
		public SysEnumElement ProductGroup { get; set; }
		public string Note { get; set; } 
    }
}

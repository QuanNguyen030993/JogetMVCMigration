using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models
{
    public class MaterialDetail : EntityBaseSysNo, IEntityBaseSysNo
    {
        public override int Id { get; set; }
		public int? MaterialId { get; set; }
		public Material Material { get; set; }
		public int? SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public double? Price { get; set; }
        public DateTime ProvideDate { get; set; }
        public int? PriorityOrder { get; set; }
		public string ReferenceCode { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models
{
    public class ProductCode : EntityBaseSysNo, IEntityBaseSysNo
    {
        public override int Id { get; set; }
        public string Index { get; set; }
        public int? ProductGroupId { get; set; }
        public SysEnumElement ProductGroup { get; set; }
        public string Description { get; set;}
        public bool IsActive { get; set; } = true;
        public DateTime ApprovalDate { get; set; }
        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int? IdeaId { get; set; }
        public SysEnumElement Idea { get; set; }
        public string Note { get; set; }
        public int? SizeScaleId { get; set; }
        public SysEnumElement SizeScale { get;  set; }
        public int? ProductLineId { get; set; }
        public SysEnumElement ProductLine { get; set; }
        public string FinalProductCode { get; set; }
        public ICollection<ProductCodeDevelopingHistory> ProductCodeDevelopingHistories { get; set; } = new List<ProductCodeDevelopingHistory>();
        public ICollection<ProductCodeOrdersHistory> ProductCodeOrdersHistories { get; set; } = new List<ProductCodeOrdersHistory>();
        public ICollection<ProductCodeManufacturingHistory> ProductCodeManufacturingHistories { get; set; } = new List<ProductCodeManufacturingHistory>();
        public int? ProductTypeId { get; set; } 
        public SysEnumElement ProductType { get; set; }
        public int? UnitId { get; set; }    
        public SysEnumElement Unit { get; set;}
    }
}

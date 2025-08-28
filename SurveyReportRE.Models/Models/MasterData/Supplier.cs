using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models
{
    public class Supplier : EntityBaseSysNo, IEntityBaseSysNo
    {
        public override int Id { get; set; }
        public string MisaCode { get; set; }
        public string SupplierFullName { get; set; }
        public string Note { get; set; }
        public int? PaymentMenthodId { get; set; }
        public SysEnumElement PaymentMenthod { get; set; }
        public bool IsActive { get; set; } = true;

        public int? SupplierGroupId { get; set; }
        public SysEnumElement SupplierGroup { get; set; }

        public int? SupplierTypeId { get; set; }
        public SysEnumElement SupplierType { get; set; }
    }
}

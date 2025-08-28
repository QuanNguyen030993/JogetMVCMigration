using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models
{
    public class Warehouse : EntityBaseSysNo, IEntityBaseSysNo
    {
        public override int Id { get; set; }
        public string WarehouseFullname { get; set;}
        public int? WarehouseTypeId { get; set;}
        public SysEnumElement WarehouseType { get; set; }
        public int? CustomerId { get; set;}
        public Customer Customer { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; } = true;
        public string MisaCode{ get; set; }
    }
}

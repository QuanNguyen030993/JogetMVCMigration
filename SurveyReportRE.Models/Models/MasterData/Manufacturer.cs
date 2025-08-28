using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models
{
    public class Manufacturer : EntityBaseSysNo, IEntityBaseSysNo
    {
        public override int Id { get; set; }
        public string ManufacturerFullname { get; set;}
        public string MisaCode { get; set;}

        public int? ManufacturerCompanyId { get; set; }
        public Manufacturer ManufacturerCompany { get; set; }

        public int? PaymentMenthodId { get; set; }
        public SysEnumElement PaymentMenthod { get; set;}

        public int? PartnerTypeId { get; set; }
        public SysEnumElement PartnerType { get; set; }

        public string Note { get; set; }
        public bool IsActive { get; set; } = true;
    }
}

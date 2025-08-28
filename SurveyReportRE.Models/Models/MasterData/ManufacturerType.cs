using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models
{
    public class ManufacturerType : EntityBase, IEntityBase
    {
        public override int Id { get; set; }
        public int PartnerTypeId { get; set; }
        public SysEnumElement PartnerType { get; set;}
        public Guid OwnerGuid { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; } = true;
    }
}

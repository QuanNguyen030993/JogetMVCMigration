using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models
{
    public class CustomerType : EntityBase, IEntityBase
    {
        public override int Id { get; set; }
        public int? CusTypeId { get; set; }
        public SysEnumElement CusType { get; set;}
        public Guid OwnerGuid { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; }
    }
}

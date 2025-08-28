using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models
{
    public class PricePolicy : EntityBase, IEntityBase
    {
        public override int Id { get; set; }
        public decimal PercentPrice { get; set; }
        public DateTime Duration { get; set;}
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; } = true;
    }
}

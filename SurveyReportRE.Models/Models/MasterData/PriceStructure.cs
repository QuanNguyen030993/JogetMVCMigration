using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models
{
    public class PriceStructure : EntityBase, IEntityBase
    {
        public override int Id { get; set; }
        //public int? CurrencyId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Note { get; set; }
        public string SysNo { get; set; }   
        public string Code { get; set; }
        public bool IsActive { get; set; } = true;
        public List<PriceStructureLine> Lines { get; set; } 
        public List<PriceStructureProfitByProduct> Profits { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models
{
    public class BankAccount : EntityBase, IEntityBase
    {
        public override int Id { get; set; }
        public string SysNo { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public Guid OwnerGuid { get; set; }
        public string OwnerName { get; set; } 
        public string OwnerAddress { get; set; }
        public string OwnerType { get; set; } 

        public string AccountNo { get; set; } 
        public string AccountName { get; set; }
        public string SwiftCode { get; set; } 
        public string Currency { get; set; }

        public int? BankId { get; set; } 
        public SysEnumElement Bank { get; set; }
        public string BankName { get; set; }

        public int? BankBrandId { get; set; }
        public SysEnumElement BankBrand { get; set; }
        public string BankBranch { get; set; }

        public string BankInfo { get; set; }
        public string BankAddress { get; set; }
        public string Remark { get; set; }
        public bool IsActive { get; set;}
        public string Note { get; set;}
    }
}

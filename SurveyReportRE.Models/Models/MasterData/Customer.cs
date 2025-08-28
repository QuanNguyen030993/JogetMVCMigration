using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models
{
    public class Customer : EntityBaseSysNo, IEntityBaseSysNo
    {
        public override int Id { get; set; }
        public string CustomerFullname { get; set; }
        public string MisaCode { get; set; }
        public int? CustomerCompanyId { get; set; }
        public Customer CustomerCompany { get; set; }
        public string Note { get; set; }
        public int? PaymentMenthodId { get; set; }
        public SysEnumElement PaymentMenthod { get; set; }
        public bool IsActive { get; set; }
        public double? PriceProgram { get; set; } //Chính sách giá
        public string Address { get; set; }
        public string TaxCode { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public string IDCardNumber { get; set; } //CCCD, CMND
        public string ContactPersonName { get; set; }
        public string ContactPersonAddress { get; set; }
        public string BankAccount { get; set; }
        public string OpenAtBank { get; set; }
        public bool? Gender { get; set; }
        public string Salutation { get; set; } // xưng hô 
        public double? MaximumDebt { get; set; }
        public double? DebtTerm { get; set; }
        public double? AccountsReceivable { get; set; }
        public double? AccountsPayable { get; set; }
        public int? ProvinceId { get; set; }
        public SysEnumElement Province { get;set;}
		public int? DistrictId { get; set; }
        public SysEnumElement District { get;set;}
		public int? WardId { get; set; }
        public SysEnumElement Ward { get;set;}
        public int SortOrder { get; set; }

        public int? CustomerGroupId { get; set; }
        public SysEnumElement CustomerGroup { get; set; }

        public int? CustomerTypeId { get; set; }
        public SysEnumElement CustomerType { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models
{
    public class Location : EntityBase, IEntityBase
    {
        public override int Id { get; set; }
        public string Fullname { get; set; }
        public string AdressNumber { get; set;}
        public string PhoneNumber { get; set; }
        public string TaxID { get; set; }
        public Guid OwnerGuid { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsPrimary { get; set; } = false;
        public string Note { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
    }
}

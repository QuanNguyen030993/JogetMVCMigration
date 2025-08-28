using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models
{
    public class Contact : EntityBase, IEntityBase
    {
        public override int Id { get; set; }
        public string ContactName { get; set; }
        public string Posistion { get; set;}
        public string PhoneNumber { get; set; }
        public Guid OwnerGuid { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; } = true;
        public string Title { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string CMNDNo { get; set; }
        public DateTime? CMNDIssueDate { get; set; }
        public string CMNDIssuePlace { get; set; }
        public string OfficePhone { get; set; }
        public string PersonalPhone { get; set; }
    }
}

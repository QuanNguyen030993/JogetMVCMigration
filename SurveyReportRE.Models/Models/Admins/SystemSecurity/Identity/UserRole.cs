using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace SurveyReportRE.Models
{
    public class UserRole : IdentityUserRole<int>, IEntityBase
    {
        [NotMapped]
        public int Id { get; set; }
        [NotMapped]
        public DateTime? CreatedDate { get; set; }
        [NotMapped]
        public string LastModifiedBy { get; set; }
        [NotMapped]
        public DateTime? LastModifiedDate { get; set; }
        [NotMapped]
        public Guid Guid { get; set; }
        public bool IsDeleted { get; set; }
        [NotMapped]
        public string CreatedBy { get; set; }
    }
}

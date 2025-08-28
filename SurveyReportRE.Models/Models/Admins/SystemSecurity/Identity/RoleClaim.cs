using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SurveyReportRE.Models
{
    public class RoleClaim : IdentityRoleClaim<int>, IEntityBase
    {
        [NotMapped]
        public DateTime? CreatedDate { get; set; }
        [NotMapped]
        public string LastModifiedBy { get; set; }
        [NotMapped]
        public DateTime? LastModifiedDate { get; set; }
        [NotMapped]
        public Guid Guid { get; set; }
        public bool IsDeleted { get; set; } = false;
        [NotMapped]
        public string CreatedBy { get; set; }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace SurveyReportRE.Models
{
    // Add profile data for application users by adding properties to the ApplicationRole class
    public class Role : IdentityRole<int>, IEntityBase
    {
        // Be carefully, Identity 2.0 always lookup NormalizedName for getting
        public Role()
        {
            RoleDutyMappings = new List<RoleDutyMapping>();
            RoleDutyClaimMappings = new List<RoleDutyClaimMapping>();
        }

        public bool? Active { get; set; }

        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public Guid Guid { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<RoleDutyMapping> RoleDutyMappings { get; set; }
        public ICollection<RoleDutyClaimMapping> RoleDutyClaimMappings { get; set; }
    }
}

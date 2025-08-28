using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace SurveyReportRE.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class User : IdentityUser<int>, IEntityBase
    {
        // Be carefully, Identity 2.0 always lookup NormalizedName for getting
        public User()
        {
            // Identity 2.0 require SecurityStamp value
            SecurityStamp = new Guid().ToString();
        }

        public bool? Active { get; set; }

        public int? EmployeeId { get; set; }
        //public Employee Employee { get; set; }
        public string EmployeeKnowAss { get; set; }

        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public Guid Guid { get; set; }
        public bool IsDeleted { get; set; }

        [MaxLength(8000)]
        public string FcmToken { get; set; }

        public override string SecurityStamp { get; set; } 
    }
}

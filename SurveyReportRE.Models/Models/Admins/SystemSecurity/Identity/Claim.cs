using System.Collections.Generic;

namespace SurveyReportRE.Models
{
    public class Claim : EntityBase, IEntityBase
    {
        public Claim()
        {
            DutyClaimMappings = new List<DutyClaimMapping>();
            RoleClaimMappings = new List<RoleDutyClaimMapping>();
        }

        public override int Id { get; set; }
        public string Area { get; set; }
        public string Page { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public ICollection<DutyClaimMapping> DutyClaimMappings { get; set; }
        public ICollection<RoleDutyClaimMapping> RoleClaimMappings { get; set; }
    }
}

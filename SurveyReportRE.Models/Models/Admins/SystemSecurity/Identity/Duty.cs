using System.Collections.Generic;

namespace SurveyReportRE.Models
{
    public class Duty : EntityBase, IEntityBase
    {
        public Duty()
        {
            RoleDutyMappings = new List<RoleDutyMapping>();
            DutyClaimMappings = new List<DutyClaimMapping>();
        }

        public override int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<RoleDutyMapping> RoleDutyMappings { get; set; }
        public ICollection<DutyClaimMapping> DutyClaimMappings { get; set; }
    }
}

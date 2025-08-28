namespace SurveyReportRE.Models
{
    public class RoleClaimMapping : EntityBase, IEntityBase
    {
        public override int Id { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        public int ClaimId { get; set; }
        //public Claim Claim { get; set; }
    }
}

namespace SurveyReportRE.Models
{
    public class DutyClaimMapping : EntityBase, IEntityBase
    {
        public override int Id { get; set; }

        public int DutyId { get; set; }
        //public Duty Duty { get; set; }

        public int ClaimId { get; set; }
        //public Claim Claim { get; set; }
    }
}

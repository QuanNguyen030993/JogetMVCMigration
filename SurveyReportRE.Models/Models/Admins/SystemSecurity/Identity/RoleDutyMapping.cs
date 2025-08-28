namespace SurveyReportRE.Models
{
    public class RoleDutyMapping : EntityBase, IEntityBase
    {
        public override int Id { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        public int DutyId { get; set; }
        //public Duty Duty { get; set; }
    }
}

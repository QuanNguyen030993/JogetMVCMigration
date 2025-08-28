using System;

namespace SurveyReportRE.Models
{
    public class UserSession : EntityBase
    {
        public override int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string UserName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal? Duration { get; set; }
        public string IPAddress { get; set; }
        public string ClientDevice { get; set; }
        public string SessionGuid { get; set; }
        public bool? Terminate { get; set; }
    }
}

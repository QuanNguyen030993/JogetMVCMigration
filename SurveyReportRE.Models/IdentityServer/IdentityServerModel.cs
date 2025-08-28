namespace SurveyReportRE.Models.IdentityServer
{
    public class IdentityServerModel
    {
        public string Authority { get; set; }
        public string Audience { get; set; }
        public bool? RequireHttpsMetadata { get; set; }
    }
}

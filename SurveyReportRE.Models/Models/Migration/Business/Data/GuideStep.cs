using SurveyReportRE.Models.Migration.Base;
using System.ComponentModel.DataAnnotations;

namespace ERPCore.Models.Migration.Config;

public class GuideStep : BaseModel
{
    [MaxLength(4000)]
    public string GuideKey { get; set; } = "";
    [MaxLength(4000)]
    public string GuideTitle { get; set; } = "";
    public int GuideVersion { get; set; } = 1;
    [MaxLength(8000)]
    public string Route { get; set; } = "";
    [MaxLength(200)]
    public string SourceType { get; set; } = "manual";
    [MaxLength(400)]
    public string WikiUrl { get; set; } = "";
    public decimal MaxLoginHours { get; set; } = 0;
    public bool AutoStart { get; set; }
    public int StepNumber { get; set; }
    [MaxLength(200)]
    public string StepTitle { get; set; } = "";
    [MaxLength(200)]
    public string Selector { get; set; } = "";
    [MaxLength(200)]
    public string Placement { get; set; } = "auto";
    [MaxLength(4000)]
    public string Content { get; set; } = "";
    [MaxLength(200)]
    public string ContentFormat { get; set; } = "html";
    public int WaitTimeoutMs { get; set; } = 5000;
    public bool IsEnabled { get; set; } = true;
}

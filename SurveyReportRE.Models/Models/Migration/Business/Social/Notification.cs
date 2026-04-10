using System;
using System.ComponentModel.DataAnnotations;
using SurveyReportRE.Models.Migration.Base;
namespace SurveyReportRE.Models.Migration.Business.Social;

public class Notification : BaseModel
{
    public string Title { get; set; } = "";
    [MaxLength(8000)]
    public string Message { get; set; } = "";
    public bool IsRead { get; set; } = false;
    [MaxLength(8000)] 
    public string? Url { get; set; } = "";
    [MaxLength(255)]
    public string? Resource { get; set; } = "";
    [MaxLength(255)]
    public string? System { get; set; } = "";
    [MaxLength(255)]
    public string? ReceivedBy { get; set; } = "";
    public Guid? RecordGuid { get; set; }


}
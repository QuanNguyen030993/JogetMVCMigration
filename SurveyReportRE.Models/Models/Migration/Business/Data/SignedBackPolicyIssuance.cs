using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SurveyReportRE.Models.Migration.Base;

public class SignedBackPolicyIssuance : BaseModel
{
    public long PolicyIssuanceId { get; set; }
    public int ReminderCount { get; set; }
    public DateTime? ReminderDate { get; set; }

    [MaxLength(4000)]
    public string? Note { get; set; } = "";
}
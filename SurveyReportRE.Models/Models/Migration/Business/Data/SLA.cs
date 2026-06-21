using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SurveyReportRE.Models.Migration.Base;

public class SLA : BaseModel
{
    [MaxLength(100)]
    public string? Dept { get; set; }
    [MaxLength(8000)]
    public string? Attributes { get; set; } 
    [MaxLength(50)]
    public string? Code { get; set; }
    public long? Value { get; set; }    
    public double? DecimalValue { get; set; }     
    public DateTime? FromDate { get; set; } 
    public DateTime? ToDate { get; set; } 
    public TimeSpan? Duration { get; set; }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SurveyReportRE.Models.Migration.Base;

public class QuotationSubDetails : BaseModel
{

    public long? DeductibleId { get; set; }
    public long? InstallmentId { get; set; }
    public long? ClauseId { get; set; } 
}

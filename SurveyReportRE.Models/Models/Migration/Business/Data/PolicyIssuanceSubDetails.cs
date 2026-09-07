using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SurveyReportRE.Models.Migration.Base;

public class PolicyIssuanceSubDetails : BaseModel
{
    public long? PolicyIssuanceId { get; set; }
    [MaxLength(255)]
    public string TranNo { get; set; }
    [MaxLength(255)]
    public string Renew { get; set; }
    [MaxLength(255)]
    public string Endorsement { get; set; }  
    [MaxLength(255)]
    public string QuotationCode { get; set; }   
    [MaxLength(255)]
    public string PolicyNo { get; set; }
    public long? ClientId { get; set; }
    [MaxLength(1000)]
    public string ClientName { get; set; }  
}
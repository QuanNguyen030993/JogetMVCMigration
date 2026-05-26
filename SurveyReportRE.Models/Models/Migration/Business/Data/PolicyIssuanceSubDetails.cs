using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SurveyReportRE.Models.Migration.Base;

public class PolicyIssuanceSubDetails : BaseModel
{
    public long? PolicyIssuanceId { get; set; } 
    public string TranNo { get; set; }
    public string Renew { get; set; }
    public string Endorsment { get; set; }  
    public string QuotationCode { get; set; }   
    public string PolicyNo { get; set; }    
}
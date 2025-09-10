using System;
using System.ComponentModel.DataAnnotations;
using SurveyReportRE.Models.Migration.Base;
namespace SurveyReportRE.Models.Migration.Business.Workflow
{
public class PendingJoget : BaseModel
{

[MaxLength(255)]
public string NextActionOnJoget {get;set;} = "";
[MaxLength(255)]
public string NextPerson {get;set;} = "";
[MaxLength(255)]
public string ActionDoneQuotationStatus {get;set;} = "";
[MaxLength(255)]
public string CompleteQuo {get;set;} = "";
[MaxLength(255)]
public string MKTFORequestedQuotationBy {get;set;} = "";
[MaxLength(255)]
public string MKTTS {get;set;} = "";
[MaxLength(255)]
public string FirstUWthatAcceptedRisk {get;set;} = "";
[MaxLength(255)]
public string PM {get;set;} = "";
[MaxLength(255)]
public string QuotationNumber {get;set;} = "";
[MaxLength(255)]
public string RequestQuotationNumber {get;set;} = "";
[MaxLength(255)]
public string DateCreatedQT {get;set;} = "";
[MaxLength(255)]
public string DateCreatedPM {get;set;} = "";
[MaxLength(255)]
public string TeamGroup {get;set;} = "";
[MaxLength(255)]
public string PolicyNumber {get;set;} = "";
[MaxLength(255)]
public string CompletePI {get;set;} = "";
[MaxLength(255)]
public string CompletedDate {get;set;} = "";
[MaxLength(255)]
public string PolicyHolder {get;set;} = "";

}
}
using System;
using System.ComponentModel.DataAnnotations;
using SurveyReportRE.Models.Migration.Base;

namespace SurveyReportRE.Models.Migration.Business.Data
{
    public class UrlCall : BaseModel
 {
    [MaxLength(4000)]
     public string Folder {get;set;} = "";
     [MaxLength(4000)]
     public string Module {get;set;}= "";
     [MaxLength(4000)]
     public string Controller { get; set; }= "";
     [MaxLength(4000)]
     public string Action { get; set; } = "";
     [MaxLength(4000)]
     public string TypeAction {get;set;}= "";
     [MaxLength(8000)]
     public string Token {get;set;} = "";
     public Guid RecordGuidId { get; set; } 
     [MaxLength(8000)]
     public string Params { get; set; }= "";
     public DateTime? ExpireTime { get; set; }
     public bool? Expired { get; set; }  = false;
 }
}

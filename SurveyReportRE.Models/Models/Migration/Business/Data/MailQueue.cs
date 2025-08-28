using System;
using System.ComponentModel.DataAnnotations;
using SurveyReportRE.Models.Migration.Base;
namespace SurveyReportRE.Models.Migration.Business.Data
{
    public class MailQueue : BaseModel
    {
        [MaxLength(8000)]
        public string ToName { get; set; } = "";
        [MaxLength(8000)]
        public string ToEmail { get; set; } = "";
        [MaxLength(8000)]
        public string Subject { get; set; } = "";
        [MaxLength(8000)]
        public string TextBody { get; set; } = "";
        [MaxLength(8000)]
        public string HtmlBody { get; set; } = "";
        [MaxLength(8000)]
        public string CC { get; set; } = "";
        [MaxLength(8000)]
        public string BCC { get; set; } = "";
        [MaxLength(8000)]
        public string FromAccount {get;set;} = "";
        [MaxLength(8000)]
        public string Type {get;set;} ="";
        [MaxLength(8000)]
        public string Attachments {get;set;}= "";
        public bool? IsSend {get;set;} = false;
    }
}
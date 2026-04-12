using System;
using System.ComponentModel.DataAnnotations;
using SurveyReportRE.Models.Migration.Base;
namespace SurveyReportRE.Models.Migration.Business.Data
{
    public class MailQueue : BaseModel
    {
        public string  to_name {get;set;} = "";
        public string  to_email {get;set;} = "";
        [MaxLength(8000)]
        public string  text_body {get;set;} = "";
        [MaxLength(8000)]
        public string  html_body {get;set;} = "";
        public string  from_account {get;set;} = "";
        [MaxLength(8000)]
        public string  is_send {get;set;} = "";
        public string ToName { get; set; } = "";
        public string ToEmail { get; set; } = "";
        public string Subject { get; set; } = "";
        [MaxLength(8000)]
        public string TextBody { get; set; } = "";
        [MaxLength(8000)]
        public string HtmlBody { get; set; } = "";
        public string CC { get; set; } = "";
        public string BCC { get; set; } = "";
        public string FromAccount { get; set; } = "";
        public string Type { get; set; } = "";
        public string Attachments { get; set; } = "";
        public bool? IsSend { get; set; } = false;
    }
}
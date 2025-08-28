using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using SurveyReportRE.Models.Migration.Base;

namespace SurveyReportRE.Models.Migration.Business.MasterData
{
    public class MailTemplate : BaseModel 
    {
        [MaxLength(4000)]
        public string TemplateName {get;set;} = "";
        [MaxLength(8000)]
        public string TemplateContent {get;set;} = "";
        [MaxLength(4000)]
        public string TemplateMailTitle {get;set;} = "";
        [MaxLength(8000)]
        public string CC {get;set;} = "";
        [MaxLength(8000)]
        public string To {get;set;} = "";
        [MaxLength(8000)]
        public string PrefixTitleMail {get;set;} = "";
        [MaxLength(8000)]
        public string BCC {get;set;} = "";
        [MaxLength(8000)]
        public string MailQuery {get;set;}= "";
        public bool? IsActive {get;set;}
    }
}



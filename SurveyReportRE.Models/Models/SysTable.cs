using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;
using SurveyReportRE.Models.Migration.Base;

namespace SurveyReportRE.Models
{
    public class SysTable : BaseModel
    {
        public string Name {get;set;} = "";
        [MaxLength(4000)]
        public string GridEditorOptions {get;set;} = "";
        [MaxLength(8000)]
        public string Export  {get;set;} = "";
        [MaxLength(4000)]
        public string ToolbarItemsConfig {get;set;} = ""; 
        public string DisplayExpr {get;set;} = "";
        public string Note {get;set;} = "";
        [MaxLength(8000)]
        public string CustomQuery {get;set;} = "";
    }
}

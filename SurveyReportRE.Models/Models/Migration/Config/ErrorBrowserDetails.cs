using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurveyReportRE.Models.Migration.Base;

namespace SurveyReportRE.Models.Migration.Config
{
    public class ErrorBrowserDetails : BaseModel
    {
        public int? Status { get; set; }
        [MaxLength(8000)]
        public string? ResponseText { get; set; } = "";
        [MaxLength(8000)]
        public string? Stack { get; set; } = "";

        [MaxLength(8000)]
        // New fields for detailed error tracing
        public string? FileName { get; set; } = "";
        public int? LineNumber { get; set; }
        public int? ColumnNumber { get; set; }
        [MaxLength(8000)]
        public string? FunctionName { get; set; } = "";
        [MaxLength(8000)]
        public string? ErrorType { get; set; } = ""; // "uncaught", "promise", "fetch", etc.
        [MaxLength(8000)]
        public string? Context { get; set; } // Page state or additional context
        public string[]? BreadcrumbTrail { get; set; } // Recent user actions
    }


}

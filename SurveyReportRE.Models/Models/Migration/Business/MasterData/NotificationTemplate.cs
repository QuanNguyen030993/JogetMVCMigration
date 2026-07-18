using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using SurveyReportRE.Models.Migration.Base;

namespace SurveyReportRE.Models.Migration.Business.MasterData
{
    public class NotificationTemplate : BaseModel
    {
        [MaxLength(255)]
        public string TemplateName { get; set; } = "";

        [MaxLength(1000)]
        public string Title { get; set; } = "";

        [MaxLength(8000)]
        public string Content { get; set; } = "";

        public bool? IsActive { get; set; }
        public long? TypeId { get; set; }

    }
}



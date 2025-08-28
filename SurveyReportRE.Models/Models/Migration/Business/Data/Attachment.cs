using SurveyReportRE.Models.Migration.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyReportRE.Models.Migration.Business.MasterData
{
    public class Attachment : BaseModel
    {
        [MaxLength(8000)]
        public string FileName { get; set; } = "";
        [MaxLength(4000)]
        public string FileType { get; set; } = "";
        [MaxLength(8000)]
        public string SubDirectory { get; set; } = "";
        public Guid? RecordGuid { get; set; }
        public long? SurveyId { get; set; }
        public long? OutlineId { get; set; }
        public string OutlinePlaceholder { get; set; } = "";
        public bool? IsDynamicOutline { get; set; }
        public long? Size { get; set; }
        public int? ItemWidth { get; set; }
        public int? ItemHeight { get; set; }
        public string SubThumbnailDirectory { get; set; } = "";
        public string SubOverviewDirectory { get; set; } = "";
        public string SubSitePictureDirectory { get; set; } = "";
        [MaxLength(8000)]
        public string AttachmentNote { get; set; } = "";
        public bool? IsPrimary { get; set; } = false;
}

}

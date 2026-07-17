using SurveyReportRE.Models.Migration.Base;
using System;
using System.ComponentModel.DataAnnotations;


namespace SurveyReportRE.Models.Migration.Business.MasterData
{
    public class ChecklistDefinition : BaseModel
    {
        public int? SequenceNo { get; set; }

        [MaxLength(2000)]
        public string Checkpoint { get; set; } = "";
        public string NeedToCheck { get; set; } = "";
        public long? LineId { get; set; }
        public long? ProductId { get; set; }
    }
}
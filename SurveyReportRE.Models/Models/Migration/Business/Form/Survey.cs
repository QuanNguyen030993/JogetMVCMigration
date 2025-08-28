using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using SurveyReportRE.Models.Migration.Base;

namespace SurveyReportRE.Models.Migration.Business.Form
{
    public class Survey : BaseModel
    {
        public long? ProtectionDetailId { get; set; }
        [MaxLength(4000)]
        public string AccompaniedBy { get; set; } = "";
        [MaxLength(4000)]
        public string CompanyName { get; set; } = "";
        [MaxLength(4000)]
        public string ConferredWith { get; set; } = "";
        public DateTime? DateOfVisit { get; set; }
        public long? ExtFireExpExposuresId { get; set; }
        [MaxLength(4000)]
        public string LatitudeLongitude { get; set; } = "";
        [MaxLength(8000)]
        public string LocationAddress { get; set; } = "";
        public long? LossHistoryId { get; set; }
        [MaxLength(8000)]
        public string Occupancy { get; set; } = "";
        [MaxLength(4000)]
        public string SurveyedBy { get; set; } = "";
        [MaxLength(8000)]
        public string SurveyedByAccountName { get; set; } = "";
        [MaxLength(8000)]
        public string Management { get; set; } = "";
        public long? ClientTypeId { get; set; }
        public long? ConstructionId { get; set; }
        [MaxLength(8000)]
        public string Construction { get; set; } = "";
        [MaxLength(8000)]
        public string Exposure { get; set; } = "";
        public long? LineOfBusinessId { get; set; }
        [MaxLength(8000)]
        public string LossHistory { get; set; } = "";
        public long? ManagementId { get; set; }
        [MaxLength(8000)]
        public string NaturalHazard { get; set; } = "";
        public long? OccupancyId { get; set; }
        [MaxLength(8000)]
        public long? OtherExposuresImgId { get; set; }
        public long? OtherExposuresId { get; set; }
        public long? ProtectionId { get; set; }
        [MaxLength(8000)]
        public string Protection { get; set; } = "";
        public long? SurveyFlowStatusId { get; set; }
        public string SurveyNo { get; set; } = "";
        public long? SurveyOverallStatusId { get; set; }
        public int? TranNo { get; set; } = 1;
        public long? ClientId { get; set; }
        public long? LocationId { get; set; }
        public long? SurveyTypeId { get; set; }
        public string SurveyedPremises { get; set; } = "";
        public string Ownership { get; set; } = "";
        public string Department { get; set; } = "";
        [MaxLength(8000)]
        public string REOpinion { get; set; } = "";
        public long? SummaryId { get; set; }
        public long? LossExpValueBrkdwnId { get; set; }
        public long? AppendixId { get; set; }
        public long? OverViewAttachmentId { get; set; }
        public long? WorkflowStatusId { get; set; }
        public long? PDFAttachmentId { get; set; }
        public string ApprovalBy { get; set; } = "";
        public DateTime? ApprovalDate { get; set; }
        [MaxLength(8000)]
        public string Comment { get; set; } = "";
        public DateTime? DueDate { get; set; }
        public string RecallReason { get; set; } = "";
        [MaxLength(8000)]
        public string GrantSurvey { get; set; } = "";
        public long? AreaId { get; set; }
        [MaxLength(4000)]
        public string ClientName { get; set; }
        public long? TypeOfOccupancy { get; set; }
        public DateTime? SubmitDate { get; set; }
        public bool? WordRendered { get; set; }
        public bool? NeedPDFConvert { get; set; }
        public bool? IsArchived { get; set; }
        public string ClientCode { get; set; } = "";
        public string OwnerReport { get; set; } = "";
        [MaxLength(8000)]
        public string PDFReplacement { get; set; } = "";
        [MaxLength(8000)]
        public string CCSiteAccount { get; set; } = "";
    }
}

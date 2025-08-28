using System;

namespace SurveyReportRE.Models
{
    public interface IEntityBase
    {
        int Id { get; set; }
        string CreatedBy { get; set; }
        DateTime? CreatedDate { get; set; }
        string LastModifiedBy { get; set; }
        DateTime? LastModifiedDate { get; set; }
        Guid Guid { get; set; }
        bool IsDeleted { get; set; }
    }
}

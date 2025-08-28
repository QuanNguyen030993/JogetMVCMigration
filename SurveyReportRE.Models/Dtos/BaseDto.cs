using System;
namespace SurveyReportRE.Models
{
    public class BaseDto
    {
        public BaseDto()
        {
            Guid = Guid.NewGuid();
        }

        public int Id { get; set; }

        public string CreatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }

        public string LastModifiedBy { get; set; }
        public DateTimeOffset? LastModifiedDate { get; set; }

        public Guid Guid { get; set; }

        public int IsDeleted { get; set; }
    }
}

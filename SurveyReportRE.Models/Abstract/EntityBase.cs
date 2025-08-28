using System;
namespace SurveyReportRE.Models
{

    public class EntityBase : IEntityBase
    {
        public EntityBase()
        {
            Guid = Guid.NewGuid();
        }

        public virtual int Id { get; set; }

        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public Guid Guid { get; set; }

        public bool IsDeleted { get; set; }
    }
    public class EntityBaseSysNo : EntityBase
    {
        public EntityBaseSysNo()
        {
            Guid = Guid.NewGuid();
        }
       public string SysNo { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
 
    }
}

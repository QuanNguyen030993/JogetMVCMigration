using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyReportRE.Models.Migration.Base
{
    public class BaseModel
    {
        public long Id { get; set; }
        public Guid Guid {get;set;} = new Guid();
        public string CreatedBy { get; set; } = "";
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public string ModifiedBy { get; set; } = "";
        public DateTime? ModifiedDate { get; set; } = DateTime.Now;
        public bool Deleted { get; set; } = false;
        public string DeletedBy { get; set; } = "";
        public DateTime? DeletedDate { get; set;} = DateTime.Now;   
        public long? RowOrder {get;set;}
        public Guid? CopyFromGuid {get;set;}
        public Guid? DraftGuid {get;set;}
    }
}

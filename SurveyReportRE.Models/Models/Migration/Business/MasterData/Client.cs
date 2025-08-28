using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurveyReportRE.Models.Migration.Base;

namespace SurveyReportRE.Models.Migration.Business.MasterData
{
    public class Client : BaseModel
    {

        [MaxLength(4000)]
        public string ClientCode { get; set; } = "";

        [MaxLength(4000)]
        public string ClientName { get; set; } = "";
        [MaxLength(4000)]
        public string PolicyCode { get; set; } = "";
        public long? OldClientCodeId { get; set; }
        public string ShortName { get; set; } = "";
        public long? AreaId { get; set; }
        
    }
}

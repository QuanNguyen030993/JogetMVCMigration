using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurveyReportRE.Models.Migration.Base;

namespace SurveyReportRE.Models.Migration.Business.MasterData
{
    public class Location : BaseModel
    {
        public long? BranchId { get; set; }

        [MaxLength(4000)]
        public string LocationAddress { get; set; } = "";

        [MaxLength(4000)]
        public string LocationName { get; set; } = "";
        public long? ClientId { get; set; }
        public string ShortLocationName { get; set; } = "";
         [MaxLength(4000)]
        public string ProvinceId { get; set; } 
         [MaxLength(4000)]
        public string DistrictId { get; set; }   
         [MaxLength(4000)]
        public string WardId { get; set; }      
         [MaxLength(4000)]
        public string StreetName { get; set; } = "";    
         [MaxLength(4000)]   
        public string StreetNumber { get; set; } = "";   
         [MaxLength(4000)]  
        public string BuildingName { get; set; } = "";    
         [MaxLength(4000)]
        public string Floor { get; set; } = "";      
         [MaxLength(4000)]     
        public string RoomNumber { get; set; } = "";
         [MaxLength(4000)]       
        public string Hamlet { get; set; } = "";  
         [MaxLength(4000)]         
        public string AreaName { get; set; } = "";    
         [MaxLength(4000)]     
        public string PostalCode { get; set; } = "";       
        public double? Latitude { get; set; }             
        public double? Longitude { get; set; }
    }
}

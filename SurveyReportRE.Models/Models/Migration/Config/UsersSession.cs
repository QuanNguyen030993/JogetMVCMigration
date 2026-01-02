using Microsoft.EntityFrameworkCore;
using SurveyReportRE.Models.Migration.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace SurveyReportRE.Models.Migration.Config
{
    public class UsersSession : BaseModel
    {
        [MaxLength(8000)]
        public string UserName { get; set; } = "";

        [MaxLength(8000)]
        public string IPAddress { get; set; } = "";

        [MaxLength(8000)]
        public string UserAgent { get; set; }  = "";
        [MaxLength(8000)]
        public string DeviceInfo { get; set; }  = "";

        [MaxLength(8000)]
        public string Token { get; set; } = "";

        public DateTime? LoginTime { get; set; } = DateTime.Now;

        public DateTime? LogoutTime { get; set; }

        public bool IsActive { get; set; } = true;
        [MaxLength(255)]
        public string SignalRConnectionId { get; set; } = "";
    }
}

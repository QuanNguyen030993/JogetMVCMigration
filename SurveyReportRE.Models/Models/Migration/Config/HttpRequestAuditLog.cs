using Microsoft.EntityFrameworkCore;
using SurveyReportRE.Models.Migration.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace SurveyReportRE.Models.Migration.Config
{
    public class HttpRequestAuditLog : BaseModel
    {

        [MaxLength(1000)]
        public string TraceId { get; set; }              // HttpContext.TraceIdentifier
        public DateTimeOffset RequestTimeUtc { get; set; }


        // ===== Request =====
        [MaxLength(1000)]

        public string Scheme { get; set; }               // http / https
        [MaxLength(1000)]

        public string Method { get; set; }               // GET / POST / PUT
        [MaxLength(1000)]

        public string Path { get; set; }                 // /api/Survey/GetSingleInclude/9
        [MaxLength(1000)]
        public string QueryString { get; set; }          // ?a=1&b=2

        [MaxLength(8000)]
        public string FullUrl { get; set; }               // https://host/api/...


        // ===== Routing =====
        [MaxLength(1000)]

        public string Controller { get; set; }           // Survey
        [MaxLength(1000)]
        public string Action { get; set; }                // GetSingleInclude

        [MaxLength(8000)]
        public string RouteValues { get; set; }           // JSON: { id: 9 }


        // ===== Client =====
        [MaxLength(1000)]

        public string ClientIp { get; set; }
        [MaxLength(1000)]

        public string UserAgent { get; set; }
        [MaxLength(1000)]
        public string Referer { get; set; }


        // ===== Authentication =====
        [MaxLength(1000)]
        public string UserName { get; set; }              // Context.User.Identity.Name

        public bool IsAuthenticated { get; set; }
        [MaxLength(1000)]
        public string AuthenticationType { get; set; }   // Bearer / Cookies / Negotiate

        [MaxLength(8000)]
        public string Claims { get; set; }                // JSON nếu cần


        // ===== Request Body =====
        [MaxLength(1000)]
        public string ContentType { get; set; }

        public long? ContentLength { get; set; }
        [MaxLength(1000)]
        public string RequestBody { get; set; }           // JSON / Form / Raw (optional)

        // ===== Response =====
        public int StatusCode { get; set; }
        public long ElapsedMilliseconds { get; set; }

        // ===== Error =====

        public bool HasException { get; set; }
        [MaxLength(1000)]
        public string Exception { get; set; }


        // ===== Extra =====
        [MaxLength(1000)]
        public string Source { get; set; }                // MVC / API / Ajax

        [MaxLength(8000)]

        public string CustomTags { get; set; }            // JSON: module, feature...
        [MaxLength(1000)]

        public string Token { get; set; }
        [MaxLength(1000)]
        public string EncryptMethod { get; set; }
    }

}

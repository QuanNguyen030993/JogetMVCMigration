using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models
{
    public class Images : EntityBase, IEntityBase
    {
        public Images()
        {

        }

        public override int Id { get; set; }
        public Guid RecordGuid { get; set; }
        [MaxLength(8000)]
        public string FileName { get; set; }
        public string Extension { get; set; }
        public string URL { get; set; }
        public string Description { get; set; }
        public int? SortOrder { get; set; }
        public bool? Active { get; set; }
        public bool? Avatar { get; set; }
        public int? CategoryId { get; set; }
        //public SysEnumElement Category { get; set; }
    }
}

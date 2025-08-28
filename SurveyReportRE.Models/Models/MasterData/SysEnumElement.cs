using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models
{
    public class SysEnumElement : EntityBase, IEntityBase
    {
        public SysEnumElement()
        {
            Active = true;
            SortOrder = 10;
        }

        public override int Id { get; set; }

        public int SysEnumId { get; set; }
        public SysEnum SysEnum { get; set; }
        
        [Required]
        public string Code     { get; set; }
        [Required]
        public string Name { get; set; }
        
        public string Caption { get; set; }

        public int? SortOrder { get; set; }

        public bool? Active { get; set; }

        public string Remark { get; set; }

        public int? ParentId { get; set; }
        public SysEnumElement Parent { get; set; }
        
        public string Value { get; set; }
        public int? Unit { get; set; }
        public string Reference { get; set; }
        [MaxLength(8000)]
        public string JsonCodeAttribute { get; set; }
    }
}

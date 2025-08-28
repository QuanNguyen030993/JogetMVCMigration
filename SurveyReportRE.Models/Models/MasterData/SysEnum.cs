using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models
{
    public class SysEnum : EntityBase, IEntityBase
    {
        public SysEnum()
        {
            SysEnumElements = new List<SysEnumElement>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        public string EnumName { get; set; }
        public string EnumCaption { get; set; }
        public bool? AdminHandling { get; set; }

        public ICollection<SysEnumElement> SysEnumElements { get; set; }

        [NotMapped]
        public const string ColorName = "Color";
    }
}

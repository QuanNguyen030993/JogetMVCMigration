using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models
{
    public class ManufacturingDetail : EntityBase, IEntityBase
    {
        public override int Id { get; set; }
        public int? ManufacturingId { get; set; }
        public Manufacturing Manufacturing { get; set; }

        public int? ManufacturerTypeId { get; set;}
        public SysEnumElement ManufacturerType { get; set;}

        public int Price { get; set; } = 0;
        public string Note { get; set; } 
        public Guid ParentGuid { get; set; }
        public Guid OwnerGuid { get; set; }

        public int? ManufacturerId { get; set; } 
        public Manufacturer Manufacturer { get; set; }
        public string ManufacturerName { get; set; }

        public bool IsActive { get; set; } = true;

        public int? ManufacturingGroupId { get; set; }
        public SysEnumElement ManufacturingGroup { get; set; }  

        public DateTime?  ValidTo { get; set; } = DateTime.Now.AddYears(50); 
    }
}

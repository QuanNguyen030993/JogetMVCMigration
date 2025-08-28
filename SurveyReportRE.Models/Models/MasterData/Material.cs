using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models
{
    public class Material : EntityBaseSysNo, IEntityBaseSysNo
    {
        public override int Id { get; set; }
        public int? UnitId { get; set; } // Đơn vị
        public SysEnumElement Unit { get; set; }
        public int? ItemTypeId { get; set; } // Loại NPL 
        public SysEnumElement ItemType { get; set; }
		public int? WidthId { get; set; } // Khổ
		public SysEnumElement Width { get; set; }
		public int? SizeId { get; set; } // Size
		public SysEnumElement Size { get; set; }
		public int? ContentId { get; set; } //Thành phần
		public SysEnumElement Content { get; set; }
		public int? ColorId { get; set; } // Màu sắc
		public SysEnumElement Color { get; set; } 
        public int? MaterialGroupId { get; set; } // Nhóm NPL
        public SysEnumElement MaterialGroup { get; set; }        
        public double? Price { get; set; } //Giá
		public string Description { get; set; } //Mô tả
        public string Note { get; set; }
        public bool IsActive { get; set; } = true;
        [MaxLength(8000)]
        public string Specification { get;set; } // Đặc tả
    }
}

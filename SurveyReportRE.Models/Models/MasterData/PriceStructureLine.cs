using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurveyReportRE.Models
{
    public class PriceStructureLine : EntityBase, IEntityBase
    {
        public override int Id { get; set; }
        public int? CostElementId { get; set; } // Tên thành phần
        public int OptionId { get; set; } // Tùy chọn 
        public SysEnumElement CostElement { get; set; }
        public double Cost { get; set; } //Giá 
        public bool IsActive { get; set; } = true; // Sử dụng
        public string Note { get; set; } // Ghi chú 
        public int PriceStructureId { get; set; }
        public int? ProductGroupId { get; set; } // Nhóm sản phẩm 
        public SysEnumElement ProductGroup { get; set; }
    }
}

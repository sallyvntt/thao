using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lib
{
    [Table("DimMst")]

    public class DimMst
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int DimMst_ID { get; set; } // Khóa chính của bảng DimMst

        [Required]
        [ForeignKey("Item")]
        public string Style_Code { get; set; } // Khóa ngoại đến bảng ItemMst (Code Of Style)

        public ItemMst Item { get; set; } // Thêm một thuộc tính để biểu thị mối quan hệ

        [ForeignKey("DiamondQuality")]
        public string DimQlty_ID { get; set; } // Khóa ngoại đến bảng DiamondQuality

        [ForeignKey("DimQualitySubType")]
        public string DimSubType_ID { get; set; } // Khóa ngoại đến bảng DimQualitySubType

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Dim_Crt { get; set; } // Carat của Kim cương

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Dim_Pcs { get; set; } // Tổng số viên kim cương trong sản phẩm

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Dim_Gm { get; set; } // Trọng lượng của từng viên kim cương (grams)

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Dim_Size { get; set; } // Kích thước của từng viên kim cương

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Dim_Rate { get; set; } // Giá của từng viên kim cương

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Dim_Amt { get; set; } // Tổng số tiền của tất cả kim cương trong sản phẩm

        

        // Khóa ngoại đến bảng DiamondQuality
        public DimQltyMst DiamondQuality { get; set; }

        // Khóa ngoại đến bảng DimQualitySubType
        public DimQltySubMst DimQualitySubType { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lib
{
    [Table("DimInfoMst")]

    public class DimInfoMst
    {
        [Key]
        [MaxLength(10)]
        public string DimID { get; set; } // Khóa chính của bảng DimInfoMst

        [Required]
        [MaxLength(50)]
        public string DimType { get; set; } // Type Of Diamond

        [Required]
        [MaxLength(50)]
        public string DimSubType { get; set; } // Sub Type Of Diamond

        [Required]
        [MaxLength(50)]
        public string DimCrt { get; set; } // Carat Of Diamond

        [Required]
        [MaxLength(50)]
        public string DimPrice { get; set; } // Price Of Diamond

        [Required]
        [MaxLength(50)]
        public string DimImg { get; set; } // Image Of Diamond

        
    }
}

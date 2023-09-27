using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lib
{
    [Table("DimQltyMst")]

    public class DimQltyMst
    {
        [System.ComponentModel.DataAnnotations.Key]
        [MaxLength(10)]
        public string DimQlty_ID { get; set; } // Khóa chính của bảng DimQltyMst

        [Required]
        [MaxLength(50)]
        public string DimQlty { get; set; } // Quality Of Diamond (AD, FD, VVS, etc…)

       
    }
}

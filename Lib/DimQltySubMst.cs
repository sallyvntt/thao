using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lib
{
    [Table("DimQltySubMst")]

    public class DimQltySubMst
    {
        [Key]
        [MaxLength(10)]
        public string DimSubType_ID { get; set; } // Khóa chính của bảng DimQltySubMst

        [Required]
        [MaxLength(50)]
        public string DimQlty { get; set; } // Quality Of Diamond

    }
}

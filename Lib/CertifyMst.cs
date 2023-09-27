using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lib
{
    [Table("CertifyMst")]

    public class CertifyMst
    {
        [Key]
        [Column(TypeName = "nchar(10)")]
        public string Certify_ID { get; set; } // Khóa chính của bảng CertifyMst

        [Required]
        [MaxLength(50)]
        public string Certify_Type { get; set; } // Name Of Certification (918, 920, etc…)

       
    }
}

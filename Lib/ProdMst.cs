using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lib
{
    [Table("ProdMst")]
    public class ProdMst
    {
        [System.ComponentModel.DataAnnotations.Key]
        [Column(TypeName = "nchar(10)")]
        public string Prod_ID { get; set; } // Khóa chính của bảng ProdMst

        [Required]
        [MaxLength(50)]
        public string Prod_Type { get; set; } // Type Of Product

       
    }
}

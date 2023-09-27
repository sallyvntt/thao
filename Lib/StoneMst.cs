using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Lib

{
    [Table("StoneMst")]

    public class StoneMst
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoneMst_ID { get; set; } // Khóa chính của bảng StoneMst

        [Required]
        [MaxLength(50)]
        public string Style_Code { get; set; } // Mã Style liên quan đến đá quý

        [ForeignKey("Style_Code")]
        public ItemMst Item { get; set; } // Mối quan hệ với bảng ItemMst

        [ForeignKey("StoneQuality")]
        public string StoneQlty_ID { get; set; } // Khóa ngoại đến bảng StoneQuality

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Stone_Gm { get; set; } // Trọng lượng của từng viên đá quý (grams)

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Stone_Pcs { get; set; } // Tổng số viên đá quý trong sản phẩm

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Stone_Crt { get; set; } // Carat của đá quý

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Stone_Rate { get; set; } // Giá của từng viên đá quý

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Stone_Amt { get; set; } // Tổng số tiền của tất cả đá quý trong sản phẩm

        // Khóa ngoại đến bảng StoneQuality
        public StoneQltyMst StoneQuality { get; set; }
    }
}

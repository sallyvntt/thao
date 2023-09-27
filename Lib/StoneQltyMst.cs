using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lib
{
    [Table("StoneQltyMst")]

    public class StoneQltyMst
    {
        [System.ComponentModel.DataAnnotations.Key]
        [MaxLength(10)]
        public string StoneQlty_ID { get; set; } // Khóa chính của bảng StoneQltyMst

        [Required]
        [MaxLength(50)]
        public string StoneQlty { get; set; } // Quality Of Stone (Ruby, Meena, etc…)

     
    }
}

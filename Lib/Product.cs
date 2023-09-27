using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    [Table("Product")]
    public class Product
    {

        [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "nchar(10)")]
        [Required]
        public string Cat_ID { get; set; }
        [ForeignKey("Cat_ID")]
        public CatMst Category { get; set; }
        public string Type_ID { get; set; }
        public string Brand_ID { get; set; }
        [ForeignKey("Brand_ID")]
        public BrandMst brandMst { get; set; }

        public string Size_Type { get; set;}
        public decimal Price { get; set; }
        public string Photo { get; set; }
        public string Detail { get; set; }
        
    }
}

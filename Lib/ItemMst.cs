using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Lib
{
    [Table("ItemMst")]

    public class ItemMst
    {
        [Key]
        [Column(TypeName = "varchar(50)")]
        public string Style_Code { get; set; }

        [Required]
        [Column(TypeName = "numeric(3,0)")]
        public int Pairs { get; set; }

        [Required]
        [Column(TypeName = "nchar(10)")]
        public string Brand_ID { get; set; }

        [Required]
        [Column(TypeName = "numeric(18,0)")]
        public int Quantity { get; set; }

        [Required]
        [Column(TypeName = "nchar(10)")]
        public string Cat_ID { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Prod_Quality { get; set; }

        [Required]
        [Column(TypeName = "nchar(10)")]
        public string Certify_ID { get; set; }

        [Required]
        [Column(TypeName = "nchar(10)")]
        public string Prod_ID { get; set; }

        [Required]
        [Column(TypeName = "nchar(10)")]
        public string GoldType_ID { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,3)")]
        public decimal Gold_Wt { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,2)")]
        public decimal Stone_Wt { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,3)")]
        public decimal Net_Gold { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,3)")]
        public decimal Wstg_Per { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,3)")]
        public decimal Wstg { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,3)")]
        public decimal Tot_Gross_Wt { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,2)")]
        public decimal Gold_Rate { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,2)")]
        public decimal Gold_Amt { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,2)")]
        public decimal Gold_Making { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,2)")]
        public decimal Stone_Making { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,2)")]
        public decimal Other_Making { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,2)")]
        public decimal Tot_Making { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,2)")]
        public decimal MRP { get; set; }

        [ForeignKey("Brand_ID")]
        public BrandMst Brand { get; set; }

        [ForeignKey("Cat_ID")]
        public CatMst Category { get; set; }

        [ForeignKey("Certify_ID")]
        public CertifyMst Certify { get; set; }

        [ForeignKey("Prod_ID")]
        public ProdMst Product { get; set; }

        [ForeignKey("GoldType_ID")]
        public GoldKrtMst GoldCarat { get; set; }

        public ICollection<DimMst> Dimensions { get; set; } = new List<DimMst>();

    }
}

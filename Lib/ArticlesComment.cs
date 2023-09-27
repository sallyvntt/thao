using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lib
{
    [Table("ArticlesComments")]
    public class ArticleComment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Comment { get; set; }

        public DateTime CommentOn { get; set; }

        [ForeignKey("ArticalId")]
        public Artical Article { get; set; }

        public int Rating { get; set; }
    }
}

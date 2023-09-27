using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lib
{
	
        [Table("User")]
        public class Users
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            [Required]
            public string Username { get; set; }
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
            [Required]
            [EmailAddress(ErrorMessage = "Format email error.")]
            public string Email { get; set; }
            [Required]
            public string PhoneNumber { get; set; }
            [Required]
            public string Address { get; set; }
            public bool Role { get; set; }
           
        }
    
}


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebFormTaskP405.Models
{
    public class RegisterModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Surname { get; set; }

        [Required]
        [MinLength(3)]
        [EmailAddress]
        [MaxLength(40)]
        [Column(TypeName = "varchar")]
        public string Email { get; set; }

        [Required]
        [StringLength(maximumLength: 16, MinimumLength = 6)]
        [Column(TypeName = "varchar")]
        public string Password { get; set; }
    }
}
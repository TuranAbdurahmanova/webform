using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebFormTaskP405.Models
{
    public class LoginModel
    {
        [Required]
        [MinLength(3)]
        [EmailAddress]
        [MaxLength(40)]
        public string Email { get; set; }

        [Required]
        [StringLength(maximumLength: 16, MinimumLength = 6)]
        public string Password { get; set; }
    }
}
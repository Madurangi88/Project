using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email Is Required")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Is Required")]
        [Display(Name = "Password")]

        public string Password { get; set; }
    }
}
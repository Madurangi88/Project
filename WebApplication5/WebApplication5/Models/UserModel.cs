using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class UserModel
    {
        public int UserId { get; set; }

        [Required (AllowEmptyStrings=false,ErrorMessage ="FirstName Is Required")]
        [Display(Name ="FirstName")]
        public string FirstName { get; set;}

        [Required(AllowEmptyStrings = false, ErrorMessage = "LastName Is Required")]
        [Display(Name = "LastName")]
        public string LastName { get; set;}

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email Is Required")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password Is Required")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "ConfirmPassword Is Required")]
        [Display(Name = "ConfirmPassword")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password and ConfirmPassword should be same")]
        public string ConfirmPassword { get; set; }

        public DateTime  Created { get; set; }

        public String SuccessMessage { get; set; }


    }
}
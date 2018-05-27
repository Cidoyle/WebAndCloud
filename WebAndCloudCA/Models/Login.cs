using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAndCloudCA.Models
{
    public class Login
    {
        [Display(Name = "Email *")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email Address required!")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Invalid Email Address")]
        [DataType(DataType.EmailAddress)]
        public string ValEmail { get; set; }

        [Display(Name = "Password *")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Invalid Password!")]
        [DataType(DataType.Password)]
        public string ValPassword { get; set; }
    }
}
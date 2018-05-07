using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAndCloudCA.Models
{
    public class Login
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Valid Email Address must be entered.")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Valid Password must be entered.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
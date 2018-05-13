using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAndCloudCA.Models
{
    public class Guest
    {
        [Display(Name="Guest Id")]
        public int GuestId { get; set; }

        [Display(Name ="First Name *")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name *")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        public string Name
        {
            get
            {
                return string.Format($"{FirstName} {LastName}");
            }
        }

        [Display(Name = "Email Address *")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage ="Enter correct email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Password *")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage ="Password must have at least 8 characters")]
        public string Password { get; set; }

        [Display(Name="Confirm Password *")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Password does not match, please re-enter")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNo { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAndCloudCA.Models
{
    public class Guest
    {
        [Key]
        [Display(Name="Guest Id")]
        public int GuestId { get; set; }

        [Display(Name ="First Name *")]
        [RegularExpression("[A-Za-z]+")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name *")]
        [RegularExpression("[A-Za-z]+")]
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
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage ="Invalid email address entered.")]
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
        [Required]
        public string PhoneNo { get; set; }
    }
}
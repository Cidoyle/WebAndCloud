using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAndCloudCA.Models
{
    public class Hostel
    {
        public int HostelId { get; set; }

        [Display(Name ="Hostel Name")]
        [Required]
        public string HostelName { get; set; }

        [Display(Name = "County")]
        [Required]
        public County CountyList { get; set; }

        [Display(Name = "Phone Number")]
        [Required]
        public string PhoneNo { get; set; }
    }
}
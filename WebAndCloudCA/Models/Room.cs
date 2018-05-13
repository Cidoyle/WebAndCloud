using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAndCloudCA.Models
{
    public class Room
    {
        public int RoomId { get; set; }

        [Display(Name ="Room Name")]
        [Required]
        public string RoomName { get; set; }

        [Display(Name = "County")]
        [Required]
        public County CountyList { get; set; }

        [Display(Name = "Phone Number")]
        [Required]
        public string PhoneNo { get; set; }
    }
}
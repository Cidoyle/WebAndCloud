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

        [Required]
        public byte[] RoomImage { get; set; }

        [Display(Name = "Room Type")]
        [Required]
        public RoomType RoomType { get; set; }

        [Display(Name = "Number of Beds")]
        [Required]
        public int NoOfBeds { get; set; }

        [Display(Name = "County")]
        [Required]
        public County CountyList { get; set; }
    }
}
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

        [Display(Name ="Address")]
        [Required]
        public string RoomAddress { get; set; }

        public decimal Price { get; set; }

        [Required]
        public string RoomImage { get; set; }
                
        [Display(Name = "Number of Guests")]
        [Required]
        public int NoOfGuests { get; set; }

        [Display(Name = "County")]
        [Required]
        public County CountyList { get; set; }


        public Room() { }
        public Room(int roomId, string address, string image, int guests, County county)
        {
            RoomId = roomId;
            RoomAddress = address;
            RoomImage = image;
            NoOfGuests = guests;
            CountyList = county;
        }
    }

    


}
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

        [Display(Name = "Address")]
        public string RoomAddress { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string RoomImage { get; set; }

        [Display(Name = "Number of Guests")]
        public int NoOfGuests { get; set; }

        [Display(Name = "County")]
        public County CountyList { get; set; }

        public IEnumerable<Room> Rooms { get; set; }


        public Room() { }
        public Room(int roomId, string address, decimal price, string image, int guests, County county)
        {
            RoomId = roomId;
            RoomAddress = address;
            Price = price;
            RoomImage = image;
            NoOfGuests = guests;
            CountyList = county;
        }
    }
}
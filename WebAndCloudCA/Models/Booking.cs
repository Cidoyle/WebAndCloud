using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAndCloudCA.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        [Display(Name ="Arrival Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime ArrivalDate { get; set; }

        [Display(Name ="Departure Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DepartureDate { get; set; }

        [Display(Name = "Number Of Guests")]
        [Required]
        public int NumberOfGuests { get; set; }

        //[Display(Name ="Guest Id")]
        //public int GuestId { get; set; }

        //[ForeignKey("GuestId")]
        //public virtual Guest Guest { get; set; }

        //[Display(Name ="Room Id")]
        //public int RoomId { get; set; }

        //[ForeignKey("RoomId")]
        //public virtual Room Room { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAndCloudCA.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        [Display(Name ="Arrival Date")]
        [Required]
        public DateTime ArrivalDate { get; set; }

        [Display(Name ="Departure Date")]
        [Required]
        public DateTime DepartureDate { get; set; }

        [Display(Name = "Number Of Guests")]
        [Required]
        public int NumberOfGuests { get; set; }
    }
}
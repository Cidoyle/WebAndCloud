using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAndCloudCA.Models;

namespace WebAndCloudCA.Controllers
{
    public class BookingDetailsController : Controller
    {
        DAO dao = new DAO();
        // GET: BookingDetails
        public ActionResult BookingDetails()
        {
            //Change to retrieve bookings just for logged in customer
            List<Booking> bookingList = dao.ShowBookings();
            return View(bookingList);
        }
    }
}
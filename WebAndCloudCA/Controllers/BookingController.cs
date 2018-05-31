using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAndCloudCA.Models;

namespace WebAndCloudCA.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        public ActionResult Booking()
        {
            //if (Session["GuestId"] != null)
            //{
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Login");
            //}      
            return View();
        }

        [HttpPost]
        public ActionResult Booking(Booking booked)
        { 
            return RedirectToAction ("BookingDetails");
        }
    }
}
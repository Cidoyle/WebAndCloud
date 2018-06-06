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
        public ActionResult BookingDetails(Booking booked)
        {
            //booked.BookingId = int.Parse(Session["bookingId"].ToString());
            dao.ShowBooking(booked);
            return View(booked);
        }
    }
}
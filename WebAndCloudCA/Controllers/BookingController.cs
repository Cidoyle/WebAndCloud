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
        DAO dao = new DAO();
        // GET: Booking
        public ActionResult Booking()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Booking(Booking booked)
        {
            int count = 0;
            if (ModelState.IsValid)
            {
                count = dao.AddBooking(booked);
                if (count > 0)
                {
                    return RedirectToAction("BookingDetails", "BookingDetails");
                }
                else
                {
                    ViewBag.Message = "Error " + dao.message;
                }
                return View();
            }
            else
            {
                return View();
            }           
    
}
    }
        }
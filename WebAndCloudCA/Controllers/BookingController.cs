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
            if (ModelState.IsValid)
            {

                return RedirectToAction("BookingDetails", "BookingDetails");
            }
            else
            {
                return View();
            }
        }
    }
}
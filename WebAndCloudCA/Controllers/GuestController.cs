using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAndCloudCA.Models;


namespace WebAndCloudCA.Controllers
{
    public class GuestController : Controller
    {
        // GET: Guest
        public ActionResult Registration()
        {
            return View();
        }
    }

    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public ActionResult Registration(Guest guest)
    //{
    //    return View(guest);
    //}
}
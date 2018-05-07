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

        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration(Guest guest)
        {
            //NOTE: Conmplete when Database is created
            //if (ModelState.IsValid)
            //{
            //    using (Database db)
            //    {
            //        db.Guest.Add(guest);
            //        db.SaveChanges();
            //        ModelState.Clear();
            //        guest=null;
            //        ViewBag.Message= "Registration Successful."
            //    }
            //}
            return View(guest);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login login)
        {
            return View(login);
        }

        [Authorize]
        public  ActionResult Logout()
        {
            //Add code 
            return RedirectToAction("Login", "Guest");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebAndCloudCA.Models;
using WebAndCloudCA.ViewModels;

namespace WebAndCloudCA.Controllers
{
    public class GuestController : Controller
    {
        // GET: Guest
        //Register
        public ActionResult Registration()
        {
            return View();
        }

        //Login - no view related, need to figure out if need it. Maybe partial view?
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration(MyAccountViewModel register)
        {
            //NOTE: Complete when Database is created
            if (ModelState.IsValid)
            {
                //    using (Database db)
                //    {
                //        db.Guest.Add(guest);
                //        db.SaveChanges();
                          ModelState.Clear();
                //        guest=null;
                          ViewBag.Message = "Registration Successful.";
                //}
            }
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(MyAccountViewModel login)
        {
            //using(Database...)
            //{ 
            //var user = db.Guest.Single(g => g.Name == user.Name && g.Password == user.Password);
            //    if (user!= null)
            //    {
            //        Session["GuestID"] = user.GuestId.ToString();
            //        Session["GuestName"] = user.GuestName.ToString();
            return RedirectToAction("AccountDetails", "AccountDetails");
            //    }
            //    else
            //    {
            //        ModelState.AddModelError("", "Username or Password are incorrect");
            //    }
            //}
            //return View();
        }

        public  ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Guest");
        }
    }
}
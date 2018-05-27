using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebAndCloudCA.Models;
using WebAndCloudCA.ViewModels;
using System.Data.SqlClient;



namespace WebAndCloudCA.Controllers
{
    public class GuestController : Controller
    {
        DAO dao = new DAO();
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
            int count = 0;
            if (ModelState.IsValid)
            {                
                count = dao.AddGuest(register);
                if (count > 0)
                {
                    ViewBag.Message = "Registration Successful";
                }
                else
                {
                    ViewBag.Message = "Error " + dao.message;
                }
                ModelState.Clear();
                return View();
            }
            else
            {
                return View(register);
            }
            ////NOTE: Complete when Database is created
            //if (ModelState.IsValid)
            //{
            //    //    using (Database db)
            //    //    {
            //    //        db.Guest.Add(guest);
            //    //        db.SaveChanges();
            //              ModelState.Clear();
            //    //        guest=null;
            //              ViewBag.Message = "Registration Successful.";
            //    //}
            //}
            //return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(MyAccountViewModel login)
        {
            
            //using (Database db)
            //{
            //    var user = db.Guest.Single(g => g.Name == db.Name && g.Password == db.Password);
            //    if (user != null)
            //    {
            //        Session["GuestID"] = user.GuestId.ToString();
            //        Session["GuestName"] = user.GuestName.ToString();
            //        return RedirectToAction("AccountDetails", "AccountDetails");
            //    }
            //    else
            //    {
            //        ModelState.AddModelError("", "Username or Password are incorrect");
            //    }
            //}
            ModelState.Clear();
            return RedirectToAction("Booking", "Booking");
        }

        public  ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Guest");
        }
    }
}
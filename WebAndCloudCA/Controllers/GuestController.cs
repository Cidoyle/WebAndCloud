using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebAndCloudCA.Models;
using WebAndCloudCA.ViewModels;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Web.Helpers;

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

        //Maybe partial view?
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration(Guest register)
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
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Guest guest)
        {
            ModelState.Remove("GuestId");
            ModelState.Remove("FirstName");
            ModelState.Remove("LastName");
            ModelState.Remove("Name");
            ModelState.Remove("ConfirmPassword");
            ModelState.Remove("Phone");
            if (ModelState.IsValid)
            {
                guest.FirstName = dao.CheckLogin(guest);
                if (guest.FirstName != null)
                {
                    Session.Add("name", guest.FirstName);
                    Session["name"] = guest.FirstName;
                    Session["email"] = guest.Email;
                    return RedirectToAction("Booking", "Booking");
                }
                else
                {
                    ViewBag.Status = "Error " + dao.message;
                }
            }
            return View();
        }

        public  ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Guest");
        }

        //Get
        public ActionResult AccountDetails(Guest guest)
        {
            Session["GuestId"] = guest.GuestId;
            return View();

        }

        //Get
        public ActionResult EditDetails()
        { 
           return View();
        }

        //[HttpPost]
        //public ActionResult EditDetails(Guest guest)
        //{
        //    //dao.EditGuest(guest);
        //    //return View();
        //}
    }
}
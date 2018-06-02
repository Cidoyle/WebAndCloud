using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAndCloudCA.Models;

namespace WebAndCloudCA.Controllers
{
    public class AccountDetailsController : Controller
    {
        DAO dao = new DAO();
        // GET: AccountDetails
        public ActionResult AccountDetails(Guest guest)
        {
            guest.Email = Session["email"].ToString();      
            dao.ShowGuestDetails(guest);
            return View(guest);             
        }

        public ActionResult EditDetails(Guest guest)
        {
            guest.Email = Session["email"].ToString();
            dao.ShowGuestDetails(guest);
            return View(guest);
        }

        /*[HttpPost]
        public ActionResult EditDetails(Guest guest)
        {
            if (ModelState.IsValid)
            {
                guest.Email = Session["email"].ToString();
                dao.EditGuest(guest);
                return RedirectToAction("AccountDetails");
            }
            return View();
        }*/
    }
}
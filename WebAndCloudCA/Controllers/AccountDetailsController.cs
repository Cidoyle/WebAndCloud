using System;
using System.Collections.Generic;
using System.Data;
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
            return View();
        }   

        //[HttpPost]
        //public ActionResult EditDetails(Guest guest)
        //{
        //    guest.Email = Session["email"].ToString();
        //    int count = 0;
        //    if (ModelState.IsValid)
        //    {
        //        count = dao.EditGuest(guest);
        //        if (count > 0)
        //        {

        //            ViewBag.Message = "Update Successful";
        //        }
        //        else
        //        {
        //            ViewBag.Message = "Error " + dao.message;
        //        }
        //        ModelState.Clear();
        //        return View();
        //    }
        //    else
        //    {
        //        return View(guest);
        //    }
        //}
    }
}
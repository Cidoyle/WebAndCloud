using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAndCloudCA.Controllers
{
    public class AccountDetailsController : Controller
    {
        // GET: AccountDetails
        public ActionResult AccountDetails()
        {
            return View();
            //if (Session["GuestID"] != null)
            //{
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Login");
            //}          
        }

        [HttpPost]
        public ActionResult EditDetails()
        {
            return View();
        }
    }
}
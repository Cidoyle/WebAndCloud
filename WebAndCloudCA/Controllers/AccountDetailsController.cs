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
            return View();//Remove this line and uncomment others when Database added
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
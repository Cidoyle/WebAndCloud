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
        // GET: AccountDetails
        public ActionResult AccountDetails()
        {
            return View();
                
        }

        public ActionResult EditDetails()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditDetails(Guest guest)
        {
            return View();
        }
    }
}
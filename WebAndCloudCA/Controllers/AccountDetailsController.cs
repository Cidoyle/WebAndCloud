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
        }

        [HttpPost]
        public ActionResult EditDetails()
        {
            return View();
        }
    }
}
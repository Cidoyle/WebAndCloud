﻿using System;
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
            Session["GuestId"] = guest.GuestId;
            return View();
                
        }

        public ActionResult EditDetails(int  id)
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
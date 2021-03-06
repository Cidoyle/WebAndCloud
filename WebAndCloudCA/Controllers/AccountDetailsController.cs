﻿using System;
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
            return View(guest);
        }

        [HttpPost]
        public ActionResult EditDetails(Guest guest, FormCollection form)
        {
            guest.Email = Session["email"].ToString();

            ModelState.Remove("Password");
            int count = 0;
            if (ModelState.IsValid)
            {
                count = dao.EditGuest(guest);
                if (count > 0)
                {
                    TempData["updated"] = "Details Successfully Updated";
                    return RedirectToAction("AccountDetails", "AccountDetails");
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
                return View(guest);
            }
        }

        [HttpPost]
        public ActionResult DeleteAccount(Guest guest)
        {
            guest.Email = Session["email"].ToString();
            dao.DeleteGuest(guest);
            TempData["message"] = "Account Deleted";
            return View(guest);

        }
    }
}
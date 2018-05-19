using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAndCloudCA.Models;
using WebAndCloudCA.ViewModels;

namespace WebAndCloudCA.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(SearchViewModel countyList, SearchViewModel arrivalDate, SearchViewModel departureDate, SearchViewModel
            noOfGuests)
        {
            //return View(db.Rooms.Where(s => s.CountyList == Rooms.CountyList ) &&
            //(db.Rooms.Where(s => s.NoOfGuests == Rooms.noOfGuests))
                return RedirectToAction("Rooms", "Rooms");
        }

    }
}
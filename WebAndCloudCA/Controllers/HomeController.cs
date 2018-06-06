using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAndCloudCA.Models;
using WebAndCloudCA.ViewModels;

namespace WebAndCloudCA.Controllers
{
    public class HomeController : Controller
    {
        DAO dao = new DAO();
        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Search (SearchViewModel county)
        {
                              
            //return View(db.Rooms.Where(s => s.CountyList == Rooms.CountyList) &&
            //(db.Rooms.Where(s => s.NoOfGuests == Rooms.NoOfGuests))
                return RedirectToAction("Rooms", "Rooms");
        }

    }
}
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
        static List<Room> selectedItems = new List<Room>();
        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Search ()
        {
        //    if (selectedItems.Count > 0)
        //    {
        //        foreach (Room item in selectedItems)
        //        {

        //            dao.SearchRooms(county);
        //        }
        //    }
        //    dao.SearchRooms(county);
        //    return View();
          return RedirectToAction("Rooms", "Rooms");
        }

    }
}
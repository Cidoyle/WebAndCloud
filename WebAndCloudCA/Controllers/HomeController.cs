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
        static List<SearchViewModel> selectedItems = new List<SearchViewModel>();
        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Search (Room room)
        {
            List<Room> roomList = dao.SearchRooms(room);
            return View(roomList);

            // return RedirectToAction("Rooms", "Rooms");
        }

    }
}
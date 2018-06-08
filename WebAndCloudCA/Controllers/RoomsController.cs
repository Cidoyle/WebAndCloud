using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAndCloudCA.Models;

namespace WebAndCloudCA.Controllers
{
    public class RoomsController : Controller
    {
        // GET: Rooms
        DAO dao = new DAO();
        

        public ActionResult Rooms()
        {
            List<Room> roomList = dao.ShowAllRooms();
            return View(roomList);
        }


        [HttpPost]
        public ActionResult Rooms(Room room)
        {
            TempData["roomSelect"] = "Please Login/Register to complete your booking";
            return RedirectToAction("Login", "Guest");
        }

    }
}
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
            //List<Room> roomList = dao.ShowAllRooms();
            return View(dao.ShowAllRooms());
        }
    }
}
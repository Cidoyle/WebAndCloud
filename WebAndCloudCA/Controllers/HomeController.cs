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

        //Search not working yet
        [HttpPost]
        public ActionResult Search (Room room)
        {
            List<Room> roomList = dao.ShowAllRooms();

            var list = from r in roomList
                       where r.CountyList == room.CountyList //&&
                                //r.NoOfGuests == room.NoOfGuests
                                select r;
            return View(list);                 
        }

    }
}
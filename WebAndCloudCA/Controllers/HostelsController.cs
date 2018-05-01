using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAndCloudCA.Controllers
{
    public class HostelsController : Controller
    {
        // GET: Hostels
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Rooms()
        {
            return View();
        }
    }
}
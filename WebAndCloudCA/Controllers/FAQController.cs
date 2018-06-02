using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace WebAndCloudCA.Controllers
{
    public class FAQController : Controller
    {
        // GET: FAQ
        public ActionResult Index()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(HttpContext.Server.MapPath("~/App_Data/FAQ.xml"));
            XmlNode root = xdoc.DocumentElement;
            XmlNode channel = root.FirstChild;
                       
            XmlNodeList list = xdoc.SelectNodes("/faq/item");            
            ViewBag.List = list;
            return View();
        }
    }
}
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
            //string url = "~/App_Data/FAQ.xml";
            XmlDocument xdoc = new XmlDocument(); // creating an instance of XmlDocument
            xdoc.Load(HttpContext.Server.MapPath("~/App_Data/FAQ.xml"));
            //xdoc.Load(url); // loading XML from the url
            XmlNode root = xdoc.DocumentElement;// gives the root node
            XmlNode channel = root.FirstChild; //First child of rss (root)

            //XmlNodeList list = channel.ChildNodes;

            //using XPath expression
            XmlNodeList list = xdoc.SelectNodes("/faq/item");
            //XmlNodeList list = xdoc.SelectNodes("/faq/item[position()<=10]");
            ViewBag.List = list;
            return View();
        }
    }
}
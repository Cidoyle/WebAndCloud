using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAndCloudCA.Models;
using System.Xml;

namespace WebAndCloudCA.Controllers
{
    public class FeedbackController : Controller
    {

        DAO dao = new DAO();
        
        static DataSet ds;
        static DataTable dt;
        
        // GET: Feedback
        public ActionResult Index()
        {
            if (System.IO.File.Exists(Server.MapPath("~/App_Data/feedback.xml")))
            {
                ds = new DataSet();
                ds.ReadXml(Server.MapPath("~/App_Data/feedback.xml"));
                dt = ds.Tables[0];
            }
            else
            {

                ds = new DataSet("user_feedback");
                dt = new DataTable("user_comments");
                dt.Columns.Add("FeedbackTopic");
                dt.Columns.Add("Description");
                ds.Tables.Add(dt);
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(Feedback model)
        {
            if (ModelState.IsValid)
            {
                DataRow row = dt.NewRow();
                row["FeedbackTopic"] = model.FeedbackTopic;
                row["Description"] = model.Description;
                dt.Rows.Add(row);
                dt.AcceptChanges();
                ds.WriteXml(Server.MapPath("~/App_Data/feedback.xml"));
                ViewData["message"] = "Feedback received. Thank you.";
                return RedirectToAction("AccountDetails", "AccountDetails");
            }

            return View(model);
        }

        public ActionResult DisplayFeedback()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(HttpContext.Server.MapPath("~/App_Data/feedback.xml"));
            XmlNode root = xdoc.DocumentElement;
            XmlNode channel = root.FirstChild;

            XmlNodeList list = xdoc.SelectNodes("/user_feedback/user_comments");
            ViewBag.List = list;
            return View();
        }
    }
}
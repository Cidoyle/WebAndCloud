﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAndCloudCA.Models;

namespace WebAndCloudCA.Controllers
{
    public class FeedbackController : Controller
    {
        // GET: Feedback
        static DataSet ds;
        static DataTable dt;

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

        //public ActionResult ShowFeedback()
        //{
        //    List<ContactModel> list = new List<ContactModel>();
        //    if (System.IO.File.Exists(Server.MapPath("~/App_Data/feedback.xml")))
        //    {
        //        DataSet dataSet = new DataSet();
        //        dataSet.ReadXml(Server.MapPath("~/App_Data/feedback.xml"));
        //        DataTable table = dataSet.Tables[0];
        //        foreach (DataRow row in table.Rows)
        //        {
        //            ContactModel model = new ContactModel();
        //            model.Name = row[0].ToString();
        //            model.Email = row[1].ToString();
        //            model.Comments = row[2].ToString();
        //            list.Add(model);
        //        }
        //        ViewData["message"] = "";
        //    }
        //    else
        //    {
        //        ViewData["message"] = "User feedback is not recorded";
        //    }

        //    return View(list);
        //}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAndCloudCA.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public FeedbackTopic FeedbackTopic { get; set; }
        public string Description { get; set; }
       
    }
}
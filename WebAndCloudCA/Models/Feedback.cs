using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAndCloudCA.Models
{
    public class Feedback
    {
        [Key]
        public int FeedbackId { get; set; }

        [Display(Name ="Topic")]
        [Required]
        public FeedbackTopic FeedbackTopic { get; set; }

        [Required]
        public string Description { get; set; }
       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAndCloudCA.Models
{
    public class Hostel
    {
        public int HostelId { get; set; }
        public string HostelName { get; set; }
        public County County { get; set; }
        public string PhoneNo { get; set; }
    }
}
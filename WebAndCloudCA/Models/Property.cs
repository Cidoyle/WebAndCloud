using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAndCloudCA.Models
{
    public class Property
    {
        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public County County { get; set; }
        public string PhoneNo { get; set; }
    }
}
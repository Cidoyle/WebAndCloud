using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace WebAndCloudCA.Models
{
    public class DAO
    {
        SqlConnection conn;

        public string message;

        public DAO()
        {

            conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        }
    }
}
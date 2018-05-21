using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using WebAndCloudCA.ViewModels;

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

        //Add Guest to DB via Registration
        public int AddGuest(MyAccountViewModel guest)
        {
            int count = 0;
            SqlCommand cmd = new SqlCommand("uspAddGuest", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@firstName", guest.Guest.FirstName);
            cmd.Parameters.AddWithValue("@lastName", guest.Guest.LastName);
            cmd.Parameters.AddWithValue("@email", guest.Guest.Email);
            cmd.Parameters.AddWithValue("@password", guest.Guest.Password);
            cmd.Parameters.AddWithValue("@phone", guest.Guest.PhoneNo);

            try
            {
                conn.Open();
                count = cmd.ExecuteNonQuery();
            }
            catch (SystemException ex)
            {
                message = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return count;
        }
    }
}
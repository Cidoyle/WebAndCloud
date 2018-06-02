﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Helpers;
using WebAndCloudCA.ViewModels;

namespace WebAndCloudCA.Models
{
    public class DAO
    {
        SqlConnection conn;
        public string message;

        #region constructor
        public DAO()
        {
            conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        }
        #endregion

        #region Rooms
        public List<Room> ShowAllRooms()
        {
            List<Room> roomList = new List<Room>();

            SqlDataReader reader;
            //Creating an instance of SqlCommand 
            SqlCommand cmd;
            //Intialising SqlCommand
            cmd = new SqlCommand("uspAllRooms", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Room room = new Room();
                    room.RoomId = int.Parse(reader["RoomId"].ToString());
                    room.RoomAddress = reader["Address"].ToString();
                    room.Price = decimal.Parse(reader["RoomPrice"].ToString());
                    room.NoOfGuests = int.Parse(reader["NumberOfGuests"].ToString());
                    room.CountyList = (County)Enum.Parse(typeof(County), reader["Address"].ToString());
                    room.RoomImage = reader["RoomImage"].ToString();
                    roomList.Add(room);
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return roomList;
        }
        #endregion
        
        #region Guest
        //Add Guest to DB via Registration
        public int AddGuest(Guest guest)
        {
            int count = 0;
            string password;
            SqlCommand cmd = new SqlCommand("uspAddGuest", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@firstName", guest.FirstName);
            cmd.Parameters.AddWithValue("@lastName", guest.LastName);
            cmd.Parameters.AddWithValue("@email", guest.Email);
            password = Crypto.HashPassword(guest.Password);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@phone", guest.PhoneNo);

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

        public string CheckLogin(Guest guest)
        {
            string password, firstName = null;
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("uspCheckLogin", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", guest.Email);
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    password = reader["Password"].ToString();
                    if (Crypto.VerifyHashedPassword(password, guest.Password))
                    {
                        firstName = reader["FirstName"].ToString();
                    }
                    else
                    {
                        message = "Passwords do not match";
                    }
                }
            }
            catch (SqlException ex)
            {
                message = ex.Message;
            }
            catch (FormatException ex1)
            {
                message = ex1.Message;
            }
            finally
            {
                conn.Close();
            }
            return firstName;
        }    

        public int EditGuest(Guest guest)
        {
            string password;
            int count = 0;
            SqlCommand cmd = new SqlCommand("uspEditDetails", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GuestId", guest.GuestId);
            cmd.Parameters.AddWithValue("@FirstName", guest.FirstName);
            cmd.Parameters.AddWithValue("@LastName", guest.LastName);
            cmd.Parameters.AddWithValue("@Email", guest.Email);
            password = Crypto.HashPassword(guest.Password);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Phone", guest.PhoneNo);

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
        #endregion

        #region Booking
        public int AddBooking (Booking booking)
        {
            int count = 0;
            SqlCommand cmd = new SqlCommand("uspAddBooking", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@arrival", booking.ArrivalDate);
            cmd.Parameters.AddWithValue("@departure", booking.DepartureDate);
            cmd.Parameters.AddWithValue("@noOfGuests", booking.NumberOfGuests);
            cmd.Parameters.AddWithValue("@guestId", booking.Guest.GuestId);
            cmd.Parameters.AddWithValue("@roomId", booking.Room.RoomId);

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
        #endregion
    }
}
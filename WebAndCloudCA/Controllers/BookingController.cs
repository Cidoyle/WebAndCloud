using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAndCloudCA.Models;

namespace WebAndCloudCA.Controllers
{
    public class BookingController : Controller
    {
        DAO dao = new DAO();
        //static List<Room> selectedRoom = new List<Room>();
        //static List<Booking> currentBooking = new List<Booking>();

        static Booking booking = new Booking();

        [HttpPost]
        public ActionResult GetRoom(FormCollection form)
        {
           
            //room.RoomId = int.Parse(form["roomId"]);
            //int id = int.Parse(form["roomId"]);

            Room room = dao.ShowRoomById();
            Session["roomAddress"] = form["roomAddress"];
            Session["RoomPrice"] = decimal.Parse(form["roomPrice"]);

            //return RedirectToAction("Booking");

            //Room room = new Room();

            room.RoomId = int.Parse(form["roomId"]);
            //room.RoomAddress = form["roomAddress"];
            //room.Price = decimal.Parse(form["roomPrice"]);


            return RedirectToAction("Booking");
        }

        public ActionResult Booking()
        {
            Room room = new Room();

            //booking.RoomAddress = "Testing Address";
            //booking.RoomPrice = 66.0m;

            booking.RoomAddress = "Testing Address";
            booking.RoomPrice = 66.0m;

            booking.RoomAddress = room.RoomAddress;
            booking.RoomPrice = room.Price;

            return View(booking);            
        }        


        //public ActionResult Booking()
        //{
        //    foreach (Room room in selectedRoom)
        //    {
        //        Booking booking = new Booking();

        //        booking.RoomAddress = room.RoomAddress;
        //        booking.RoomPrice = room.Price;
        //        if (!currentBooking.Contains(booking))
        //            currentBooking.Add(booking);                
        //    }

        //    return View(Booking);
        //    //Room room = new Room();
        //    //currentBooking.RoomAddress = room.RoomAddress;
        //    //currentBooking.RoomPrice = room.Price;

        //    //return View(currentBooking);


        //}

        //[HttpPost]
        //public ActionResult AddRoom(FormCollection form)
        //{
        //    List<Room> list = dao.ShowAllRooms();
        //    bool found = false, found1 = false;

        //    for (int i = 0; i < currentBooking.Count && found == false; i++)
        //    {
        //        //if already in the selected items
        //        if (currentBooking[i].RoomId == int.Parse(form["roomId"]))
        //        {
        //            currentBooking[i].RoomAddress = form["roomAddress"];
        //            currentBooking[i].RoomPrice = decimal.Parse(form["roomPrice"]);
        //            found = true;
        //            found1 = true;
        //        }
        //    }

        //    for (int i = 0; i < list.Count && found1 == false; i++)
        //    {
        //        if (list[i].RoomId == int.Parse(form["roomId"]))
        //        {
        //            list[i].RoomAddress = form["roomAddress"];
        //            list[i].Price = decimal.Parse(form["roomPrice"]);
        //            selectedRoom.Add(list[i]);
        //            found1 = true;
        //        }
        //    }

        //    return RedirectToAction("Booking");
        //}

        // GET: Booking
        //public ActionResult Booking()
        //{
        //    Room room = new Room();
        //    currentBooking.RoomAddress = room.RoomAddress;
        //    currentBooking.RoomPrice = room.Price;

        //    return View(currentBooking);
        //}


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Booking(Booking booked)
        //{

        //    int count = 0;
        //    if (ModelState.IsValid)
        //    {
        //        count = dao.AddBooking(booked);
        //        if (count > 0)
        //        {
        //            ViewBag.Message = "Booking Successful";
        //           // return RedirectToAction("BookingDetails", "BookingDetails");
        //        }
        //        else
        //        {
        //            ViewBag.Message = "Error " + dao.message;
        //        }
        //        return View();
        //    }
        //    else
        //    {
        //        return View();
        //    }   
        //}     
    }
}
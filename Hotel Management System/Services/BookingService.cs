using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Services
{
   public class BookingService
    {
        public static void DisplayAllBookings(List<BookingModel> booking)
        {
            //List<BookingModel> booking = new List<BookingModel>();

            foreach(BookingModel book in booking)
            {
                Console.WriteLine($"booking Id: {book.bookingId}," +
                    $"guest Id: {book.guestId}," +
                    $"room Number: {book.roomNumber}," +
                    $"checkInDate: {book.checkInDate}," +
                    $"checkOutDate: {book.checkOutDate}," +
                    $"totalPrice: {book.totalPrice}," +
                    $"status: {book.status}");
            }
        }

        public static BookingModel FindBookingById(List<BookingModel> bookid, string bookingId, string bid)
        {
           

            foreach(BookingModel booking in bookid)
            {
                if (booking.bookingId == bid)
                {
                    return booking;                }
            }
            return null;
        }

        public static bool CancelBooking(BookingModel cancelbook,string bookingId)
        {
          
            

                if(cancelbook.status == "cancelled") 
                {
                return false;
                }
               else
               {
                cancelbook.status = "cancelled";
                return true;
               }

            }
        
        public static bool CompleteBooking(BookingModel booking, RoomMode room, string roomnum)
        {
          
             
            if (booking.status == "completed") 
                {
                return true;
                  
                     
                }
            else {
                booking.status = "completed";
            }
            return false;
           
        }



    }
}

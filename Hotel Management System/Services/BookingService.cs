using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Services
{
   public class BookingService
    {
        public static void DisplayAllBookings()
        {
            List<BookingModel> booking = new List<BookingModel>();

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

        public static void FindBookingById( string bookingId, string bid)
        {
            List<BookingModel> bookid = new List<BookingModel>();

            foreach(BookingModel bookId in bookid)
            {
                if(bookId.bookingId == bid)
                {
                    Console.WriteLine($"Bookig Id : {bid} matching with Id: {bookId.bookingId} ");
                }
                else
                {
                    Console.WriteLine("No Match Id");
                }
            }
        }

        public static void CancelBooking(string bookingId)
        {
            List<BookingModel> cancelbook = new List<BookingModel>();
            
            bool check = false;
            foreach(BookingModel cancel in cancelbook)
            {
                if(cancel.bookingId == bookingId)
                {
                    cancel.status = "cancelled";
                    Console.WriteLine($"Booking ID : {cancel.bookingId} is Canceled{check}");
                    check =true;
                    break;
                }
                if(!check)
                {
                    Console.WriteLine("Booking already cancelled");
                }
                }
            }
        
        public static bool CompleteBooking(BookingModel booking, RoomMode room, string roomnum)
        {
            foreach(BookingModel comp in new List<BookingModel>())
             
            if (comp.roomNumber == roomnum) 
                {
                    comp.status = "completed";
                  
                     //RoomMode.isAvailable;
                }
            return true;
           
        }



    }
}

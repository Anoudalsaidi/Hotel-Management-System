using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
    }
}

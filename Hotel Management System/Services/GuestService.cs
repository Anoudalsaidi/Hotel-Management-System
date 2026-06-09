using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Hotel_Management_System.Services
{
    public static class GuestService
    {
        public static void DisplayAllGuests()
        {
            List<GuestModel> GuestM = new List<GuestModel>();
            
           foreach (GuestModel item in GuestM)
            {
                Console.WriteLine($"Guest Id :{item.guestId}," +
                    $"Full Name: {item.fullName}," +
                    $"Email: {item.email}," +
                    $"Phone Number : {item.phoneNumber}");
            }
        }

        public static void FindGuestById(string guestid)
        {
            List<GuestModel> GMid = new List<GuestModel>();


            foreach (GuestModel item in GMid)
            {
                if (item.guestId == guestid)
                {
                    Console.WriteLine($"Guest ID is :{item.guestId}");

                }
                else
                {
                    Console.WriteLine("Guest Not Found");
                }
            }
        }

    }
}

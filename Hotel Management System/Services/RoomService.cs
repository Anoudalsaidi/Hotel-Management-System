using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Services
{
   public  class RoomService
    {
        public static void DisplayAllRooms(List<RoomMode> room)
        {
            

            foreach(RoomMode item in room){
                Console.WriteLine($"Room Number: {item.roomNumber}," +
                    $"Room Type: {item.roomType}," +
                    $"price Per Night: {item.pricePerNight}," +
                    $"is Available: {item.isAvailable} ");
            }
        }

        public static void DisplayAvailableRooms(List<RoomMode> roo)
        {

            foreach (RoomMode item in roo)
            {
                if (item.isAvailable == true)
                   
                {
                    Console.WriteLine($"Room is Available{item.isAvailable} ");
                     
                }

                else
                {
                    Console.WriteLine($"Room is Not Available{item.isAvailable} ");
                }
            }
        }

        public static RoomMode FindRoomByNumber(List<RoomMode> searchroom, string seachroomnum)
        {
           ;

            foreach (RoomMode item in searchroom)
            {
                if (item.roomNumber == seachroomnum)
                {
                    return item;
                }
              

            }

            return null;
        }

        public static double CalculateTotalPrice(RoomMode calprice, int nights)
        {

            return calprice.pricePerNight * nights;
        
        

            Console.WriteLine($"Total price : Nights{nights} * price per Night = {calprice.pricePerNight}");
        }

    }
}

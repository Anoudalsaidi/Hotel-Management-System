using Hotel_Management_System.Models;
using Hotel_Management_System.Services;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Hotel_Management_System
{
    public class Program
    {
        public static void RegisterGuest(HotelContext context) //case 1
        {

            Console.WriteLine("Enter Guest ID :");
            String guestid = Console.ReadLine();
            Console.WriteLine("Enter Full Name:");
            String fullname = Console.ReadLine();
            Console.WriteLine("Enter email  :");
            String Email = Console.ReadLine();
            Console.WriteLine("Enter phone Number :");
            String phonenumber = Console.ReadLine();
            context.guests.Add(new GuestModel
            {
                guestId = guestid,
                fullName = fullname,
                email = Email,
                phoneNumber = phonenumber,
                guest = new List<BookingModel>()

            });

        

            EmailService.SendEmail(Email, "Welcome to Grand Codeline Hotel", "Thank you for registering. We look forward to hosting you!");
            Console.WriteLine("Guest Registered Successfuly");
        }
        public static void AddRoom(HotelContext context)// case 2
        {
            Console.WriteLine("Enter room Number:");
            String roomnumber = Console.ReadLine();
            Console.WriteLine("Enter room Type :");
            String roomtype = Console.ReadLine();
            Console.WriteLine("Enter price Per Night :");
            double priceperNight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter floor :");
            int flooor = Convert.ToInt32(Console.ReadLine());
            context.rooms.Add(new RoomMode
            {
                roomNumber = roomnumber,
                roomType = roomtype,
                pricePerNight = priceperNight,
                isAvailable = true,
                floor = flooor,
            });
            Console.WriteLine("Romm Added Sucessfully");


        }
        public static void DisplayAvailableRooms(HotelContext context) // case 3
        {
            if (context.rooms == null)
            {
                Console.WriteLine("No rooms in system");
            }
            else
            {
                RoomService.DisplayAvailableRooms(context.rooms);
            }
        }
        public static void AddStaff(HotelContext context)
        {
            Console.WriteLine("Enter Staff ID :");
            String staffid = Console.ReadLine();
            Console.WriteLine("Enter Full Name:");
            String fullname = Console.ReadLine();
            Console.WriteLine("Enter email  :");
            String Email = Console.ReadLine();
            Console.WriteLine("Enter Role  :");
            String Role = Console.ReadLine();

            context.staff.Add(new StaffModel
            {
                staffId = staffid,
                fullName = fullname,
                role = Role,
                email = Email,
                isOnDuty = true

            });
            Console.WriteLine("Staff Added Successfuly");
        } // case 4


        public static void DisplayAllStaff(HotelContext context)
        {
            StaffService.DisplayAllStaff(context.staff);
        } // case 5







        public static void Main(string[] args)
        {
            HotelContext context = new HotelContext();
            context.boookings = new List<BookingModel>();
            context.guests = new List<GuestModel>();
            context.reviews = new List<ReviewModel>();
            context.rooms = new List<RoomMode>();
            context.staff = new List<StaffModel>();
            RoomService servise = new RoomService();
           


            bool loop = false;
            while (loop == false)

                Console.WriteLine("Welcome to Grand Codeline Hotel");
            Console.WriteLine("1. Register Guest");
            Console.WriteLine("2. Add Room");
            Console.WriteLine("3. Display Available Rooms");
            Console.WriteLine("4. Add Staff");
            Console.WriteLine("5. Display All Staff");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    RegisterGuest(context);
                    break;
                case 2:
                    AddRoom(context);
                    break;
                case 3:
                    DisplayAvailableRooms(context);
                    break;
                case 4:
                    AddStaff(context);
                    break;
                case 5:
                    DisplayAllStaff(context);
                    break;
            }
        }



     }
}

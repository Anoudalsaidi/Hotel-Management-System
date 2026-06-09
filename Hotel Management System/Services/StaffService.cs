using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Services
{
    public class StaffService
    {
        public static void DisplayAllStaff(List<StaffModel> stt)
        {
            foreach (StaffModel staff in stt)
            {
                Console.WriteLine($"");
            }

        }
    }
}

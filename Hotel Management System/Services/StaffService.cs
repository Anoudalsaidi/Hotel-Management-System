using Hotel_Management_System.Models;
using System;
using System.Collections;
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
                Console.WriteLine($"staff Id{staff.staffId}," +
                    $"full Name:{staff.fullName}," +
                    $"role:{staff.role}," +
                    $"is on Duty:{staff.isOnDuty}");
            }

        }

        public static string FindStaffById(List<StaffModel> staf, string staffid)
        {
            foreach (StaffModel staff in staf)
            {
                if (staff.staffId == staffid)
                {
                    return staffid;
                }
                else
                {
                    Console.WriteLine("No matching ");
                }
               
            }
            return staffid;
        }


        public static void ToggleDutyStatus(StaffModel duty)
        {
          
            if(duty.isOnDuty == true)
            {
                duty.isOnDuty = false;
            }
            else
            {
                duty.isOnDuty = true;
            }
           
        }


    }
}

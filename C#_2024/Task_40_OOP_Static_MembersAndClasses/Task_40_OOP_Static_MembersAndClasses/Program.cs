using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_40_OOP_Static_MembersAndClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User.Identifications = 10;
            User user1 = new User();
            User user2 = new User();
            user1.ShowInfo();
            user2.ShowInfo();

        }

        class User
        {
            public static int Identifications;
            public int Identification;
            public static int MenHourPrice;

            public User()
            {
                Identification = ++Identifications;
            }

            public void ShowInfo()
            {
                Console.WriteLine(Identification);
            }

            public static int GetSalaryPerDay(int workedHours)
            {
                return MenHourPrice * workedHours;
            }

            public int GetSalaryPerMonth (int workedDays)
            {
                return GetSalaryPerDay(8) * workedDays;
            }


        }




    }
}


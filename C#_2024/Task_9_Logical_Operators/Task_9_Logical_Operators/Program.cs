using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_Logical_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int _money = 500;
            int _level = 10;

            if (_money >= 500  || _level > 10)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("\nУ вас не достаточно денег и уровня !");
            }






        }
    }
}

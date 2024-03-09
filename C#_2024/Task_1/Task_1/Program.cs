using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int _timeInMinuts = 130;
            int _hour;
            int _minute;

            _hour = _timeInMinuts / 60;
            _minute = _timeInMinuts % 60;

            Console.WriteLine("Hour - " + _hour);
            Console.WriteLine("Minuts - " + _minute);


        }
    }
}

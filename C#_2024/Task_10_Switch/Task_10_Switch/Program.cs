using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _dayOfWeek;

            Console.Write("Input day: ");
            _dayOfWeek = Console.ReadLine();

            switch (_dayOfWeek)
            {
                case "Monday":
                case "Suturday":
                case "Sunday":
                    Console.WriteLine("Go to the movie");
                    Console.WriteLine("Eats pop's");
                    break;
                case "Tuesday":
                    Console.WriteLine("2");
                    break;
                case "Wednesday":
                    Console.WriteLine("3");
                    break;
                case "Thursday":
                    Console.WriteLine("4");
                    break;
                case "Friday":
                    Console.WriteLine("5"); 
                    break;

                    default: Console.WriteLine("I DON'T KNOW");
                    break;

            }






        }
    }
}

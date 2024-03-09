using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int _age;

            Console.Write("Input Your Age: ");
            _age = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < 100; i += 2)
            {

                if (i == 0)
                {
                    continue;
                }
                Console.WriteLine($"HAPPY BIRTHDAY! YOU {i} AGE");
            }




        }
    }
}

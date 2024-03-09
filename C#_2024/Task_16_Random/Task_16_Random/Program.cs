using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int _value;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(rand.Next(0, 10));
            }


            //while (true)
            //{
            //    _value = rand.Next(0, 11);
            //    Console.WriteLine(_value);
            //    Console.ReadKey();
            //}

        }
    }
}

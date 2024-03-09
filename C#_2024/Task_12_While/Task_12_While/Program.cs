using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_While
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int _age;

            Console.Write("Input Your Age: ");
            _age = Convert.ToInt32(Console.ReadLine());

            while (_age-- > 0)
            {
                Console.WriteLine("Happy Birthday");

                if (_age == 5)
                {
                    break;
                }

            }











        }
    }
}

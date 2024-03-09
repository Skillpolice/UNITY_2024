using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_14_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int _age;

            Console.Write("Inout your Age: ");
            _age = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < _age; i += 2)
            {
                if (i == 0)
                {
                    continue;
                }

                Console.WriteLine($"Happy birthday {_age} years {i}");
            }


        }
    }
}

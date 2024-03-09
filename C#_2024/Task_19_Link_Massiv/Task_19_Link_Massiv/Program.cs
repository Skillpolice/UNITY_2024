using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task_19_Link_Massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bag = new int[1];
            bag[0] = 12;

            int[] tempBag = new int[bag.Length + 1];

            for (int i = 0; i < bag.Length; i++)
            {
                tempBag[i] = bag[i];
                Console.WriteLine(tempBag[i] + " Первый");

            }

            tempBag[tempBag.Length - 1] = 54;

            bag = tempBag;

            for (int i = 0;i < bag.Length; i++)
            {
                Console.WriteLine(bag[i] + " Второй");
            }

           
        }



        //Example 1

        //int[] _array1 = new int[3];
        //int[] _array2 = new int[5];
        //int[] _array3;

        //_array1 = _array2;

        //_array1[0] = 5;
        //_array1[1] = 3;

        //_array3 = _array1;

        //_array3[0] = 10;
        //_array3[2] = 4;

        //Console.WriteLine(_array2[0]);
        //Console.WriteLine(_array2[1]);

        //_array1 = new int[10];
    }
}

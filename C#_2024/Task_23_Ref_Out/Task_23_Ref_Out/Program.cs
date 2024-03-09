using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_23_Ref_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            array = EditArray(array, 2, 5);

            Console.WriteLine(array[2]);
        }

        static int[] EditArray(int[] array, int index, int value)
        {
            array = new int[7];
            array[index] = value;

            return array;
        }

    }



    // Example 1

    //static void Main(string[] args)
    //{
    //    int sum, x = 1, y = 5;
    //    Add(out sum, x, y);
    //    Console.WriteLine(sum);
    //}

    //static void Add(out int sum, int x, int y) // REF - ВХодные ссылочные параметры ||| OUT - Выходные ссылочные параметры
    //{
    //    sum = x + y; ;

    //}
}

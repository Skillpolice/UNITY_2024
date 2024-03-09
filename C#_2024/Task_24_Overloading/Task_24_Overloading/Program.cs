using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_24_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int[,] array2 = new int[5, 5];

            array = Resize(array, 6);
            array2 = Resize(array2, 10, 10);

            Console.WriteLine(array.Length);
            Console.WriteLine(array2.Length);



        }

        static int[] Resize(int[] arrayFun, int size)
        {
            int[] tempArray = new int[size];
            for (int i = 0; i < arrayFun.Length; i++)
            {
                tempArray[i] = arrayFun[i];
            }

            arrayFun = tempArray;

            return arrayFun;
        }

        static int[,] Resize(int[,] arrayFun2, int x, int y)
        {
            int[,] tempArrey = new int[x, y];

            for (int i = 0; i < arrayFun2.GetLength(0); i++)
            {
                for (int j = 0; j < arrayFun2.GetLength(1); j++)
                {
                    tempArrey[i, j] = arrayFun2[i, j];
                }
            }

            arrayFun2 = tempArrey;
            return arrayFun2;

        }
    }
}

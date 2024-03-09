using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_Intcrement_Dickrement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 0; //     0 + 1 + 1
            //Console.WriteLine(i++ + ++i);

            int A = 0;       // 1 + 2 + 1 +  1  + "1" +  3  * 2
            Console.WriteLine(++A + 2 + 1 + A++ + "1" + ++A * 2); //Инкремент и Дикрепет в приоритете потом остально



        }
    }
}

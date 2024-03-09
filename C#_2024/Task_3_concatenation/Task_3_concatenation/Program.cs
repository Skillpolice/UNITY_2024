using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_concatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string _str1 = "Hello";
            //string _str2 = "World";
            //string _message;
            //_message = _str1 + _str2;
            //Console.WriteLine(_message);


            int _age = 15;
            Console.WriteLine("Привет, тебе завтра исплниться: " + (_age + 1));


            int _age1 = 30;
            string _name = "Denis";

            Console.WriteLine("Ваше именя: " + _name + " вам " + _age);
            Console.WriteLine($"Ваше имя: {_name} вам {_age} лет"); // Инторполяция строк



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Если не выводит кирилицу
            /*Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;*/

            string _name;
            int _age;

            Console.Write("Введите ваше имя: ");
            _name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            _age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ваше имя: {_name}");
            Console.WriteLine($"Ваш возраст: {_age}");





        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_22_Functions_C_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Привет!");
            Console.WriteLine("Ты здесь ?");

            WriteError("Нет соединения с интернетом !!!", ConsoleColor.Cyan, '2');

            Console.WriteLine("Странно...");

            WriteError("Интернет не оплачен!", sym: '@');

        }

        static void WriteError(string text, ConsoleColor color = ConsoleColor.Red, char sym = '!') //ConsoleColor color = ConsoleColor.Red - необязательный параметр
        {
            ConsoleColor dufaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(sym + text);
            Console.ForegroundColor = dufaultColor;
        }

    }


    // Example 1

    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Привет!");
    //    Console.WriteLine("Ты здесь ?");

    //    WriteError("Нет соединения с интернетом !!!");

    //    Console.WriteLine("Странно...");

    //    WriteError("Интернет не оплачен!");

    //}


    //static void WriteError(string text)
    //{
    //    ConsoleColor dufaultColor = Console.ForegroundColor;
    //    Console.ForegroundColor = ConsoleColor.Red;
    //    Console.WriteLine(text);
    //    Console.ForegroundColor = dufaultColor;
    //}

    //Example 2

    //static void Main(string[] args)
    //{
    //    int x = 4 ;
    //    int y = 3;

    //    int sum = Sum(x, y) + 2;
    //    Console.WriteLine(sum);

    //}

    //static int Sum(int x, int y)
    //{
    //    int sum;
    //    sum = x + y;

    //    return sum;
    //}









}

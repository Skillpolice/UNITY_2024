using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_25_TestWork_HealthBat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int helath = 5;
            int maxHealth = 10;

            int mana = 5;
            int maxMana = 10;

            while (true)
            {
                DrawBar(helath, maxHealth, color: ConsoleColor.Green, 0, '|');
                DrawBar(mana, maxMana, color: ConsoleColor.Blue, 1);

                Console.SetCursorPosition(0, 5);
                Console.Write("Введите число, на которое измениться жизнь: ");
                helath += Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите число, на которое измениться мана: ");
                mana += Convert.ToInt32(Console.ReadLine());


                Console.ReadKey();
                Console.Clear();


            }
        }

        static void DrawBar(int value, int maxValue, ConsoleColor color, int position, char symbol = '_')
        {
            ConsoleColor defaultColor = Console.BackgroundColor;

            string bar = "";

            for (int i = 0; i < value; i++) //отрисовка пробелов в цвете
            {
                bar += symbol;
            }

            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            for (int i = value; i < maxValue; i++) //отрисовка пустых  пробелов 
            {
                bar += " ";
            }

            Console.Write(bar + ']');
        }


    }
}

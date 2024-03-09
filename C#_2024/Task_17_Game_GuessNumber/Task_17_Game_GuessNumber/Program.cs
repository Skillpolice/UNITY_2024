using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17_Game_GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int _number;

            //граница диапазона
            int _lowyer;
            int _higher;

            int _triesCount = 5;
            int _userInput;

            _number = rand.Next(0, 101);
            _lowyer = rand.Next(_number - 10, _number);
            _higher = rand.Next(_number + 1, _number + 10);

            Console.WriteLine($"Мы загадали число от 0 дл 100, оно больше чем {_lowyer}, но меньше чем {_higher}");
            Console.WriteLine($"Число попыток ограничено, у вас осталось {_triesCount} попыток.");


            while (_triesCount-- > 0)
            {
                Console.Write("Ваш ответ: ");
                _userInput = Convert.ToInt32(Console.ReadLine());

                if (_userInput == _number)
                {
                    Console.WriteLine("Вы правы, это было число " + _number + ".");
                    break;
                }
                else if (_lowyer != _number)
                {
                    Console.WriteLine($"Не правельно!!! у вас осталось {_triesCount} попыток.");
                }

            }

            Console.WriteLine("Это было число " + _number);







        }
    }
}

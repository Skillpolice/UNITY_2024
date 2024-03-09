using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_TEST_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ВЫСЧИТЫВАЕМ УРОН

            float _health;
            float _armor;
            float _damage;
            float _precentConverter = 100f;

            Console.Write("Input max Health: ");
            _health = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input max Armor: ");
            _armor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Damage: ");
            _damage = Convert.ToInt32(Console.ReadLine());

            _health -= _damage * (_armor / _precentConverter);
            Console.WriteLine($"\nВам нанесли {_damage} урона!!! У вас осталось {_health} жизни. ");

            //int _money;
            //int _food;
            //int _foodPrice = 10;
            //bool _isAbleToPay;

            //Console.WriteLine("Сегодня еда по " + _foodPrice + " монет");

            //Console.Write("Сколько у вас Золота ? ");
            //_money = Convert.ToInt32(Console.ReadLine());

            //Console.Write("сколько еды вам нужно ? ");
            //_food = Convert.ToInt32(Console.ReadLine());

            //_isAbleToPay = _money >= _food * _foodPrice;
            //_food *= Convert.ToInt32(_isAbleToPay);
            //_money -= _food * _foodPrice;

            //Console.WriteLine($"У вас в сумкe {_food} еды и {_money} монет !");










        }
    }
}

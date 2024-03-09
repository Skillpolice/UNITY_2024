using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_15_TEST_WORK
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Сражение игроков

            float _playerHealth = 100f;
            float _playerDamage = 10f;
            float _enemyHealth = 50f;
            float _enemyDamage = 15f;


            while (_playerHealth > 0 && _enemyHealth > 0)
            {
                _playerHealth -= _enemyDamage;
                _enemyHealth -= _playerDamage;

                Console.WriteLine(_playerHealth + " Player Health");
                Console.WriteLine(_enemyHealth + " Enemy Health");

            }

            if (_playerHealth <= 0 && _enemyHealth <= 0)
            {
                Console.WriteLine("DRAW");
            }
            else if (_enemyHealth <= 0)
            {
                Console.WriteLine("Won Player");
            }
            else if (_playerHealth <= 0)
            {
                Console.WriteLine("Won Enemy");
            }



            //Процент в Банке

            //float _money;
            //int _years;
            //int _precent;

            //Console.Write("Введите кол-во денег, внесенный на вклад: ");
            //_money = Convert.ToSingle(Console.ReadLine());

            //Console.Write("На сколько лет открыть вклад: ");
            //_years = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Под какой процент: ");
            //_precent = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < _years; i++)
            //{
            //    _money += _money / 100 * _precent;
            //    Console.WriteLine("В этом году у вас " + _money);
            //    Console.ReadKey();
            //}



            //Проверка пароля и кол-во кнр ввода

            //int _triesCount = 5;
            //string _password = "12345";
            //string _userInpit;


            //for (int i = 0; i < _triesCount; i++)
            //{
            //    Console.Write("Input your password: ");
            //    _userInpit = Console.ReadLine();

            //    if (_userInpit == _password)
            //    {
            //        Console.WriteLine("WORK");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("ERROR");
            //        Console.WriteLine($"Your have {_triesCount - i - 1} tries left");
            //    }
            //}

        }
    }
}

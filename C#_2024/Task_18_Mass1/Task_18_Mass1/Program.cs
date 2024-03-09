using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Task_18_Mass1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] _sectors = { 6, 25, 15, 15, 10 };
            bool _isOpen = true;

            while (_isOpen)
            {
                Console.SetCursorPosition(0, 18);

                for (int i = 0; i < _sectors.Length; i++)
                {
                    Console.WriteLine($"В секторе {i + 1} свободно {_sectors[i]} мест.");
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Ругистранция рейса.");
                Console.WriteLine("\n1 - Бронирование мест: \n2 - Выход из программы: ");
                Console.Write("Введите номер команды: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int _userSector, _userPlaceAmount;

                        Console.WriteLine("В каком секторе вы хотите лететь? ");
                        _userSector = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (_sectors.Length < _userSector || _userSector < 0)
                        {
                            Console.WriteLine("Такого сектора не сужествует");
                            break;
                        }


                        Console.WriteLine("Сколько мест вы хотите забронировать?");
                        _userPlaceAmount = Convert.ToInt32(Console.ReadLine());
                        if(_userPlaceAmount < 0)
                        {
                            Console.WriteLine("Не достаточно мест");
                            break;
                        }
                        if (_sectors[_userSector] < _userPlaceAmount)
                        {
                            Console.WriteLine($"В секторе {_userSector + 1} недостаточно мест, Мест в Секторе {_sectors[_userSector]}");
                            break;
                        }

                        _sectors[_userSector] -= _userPlaceAmount;
                        Console.WriteLine("Бронирование успешно !");

                        break;

                    case 2:
                        _isOpen = false;
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }


        }


        //Task 1
        //Random random = new Random();
        //int[] mas = new int[10];
        //Console.WriteLine($"Lenght MASS = {mas.Length}");

        ////mas[7] = 13;
        ////mas[3] = 14;

        //for (int i = 0; i < mas.Length; i++)
        //{
        //    mas[i] = random.Next(0, 10);
        //    Console.WriteLine(mas[i] + " ");
        //}


        //Task 2
        //int[] _array = { 1, 2, 3, 4, 5, 6, 7, 8, };
        //int _sum = 0;

        //for (int i = 0; i < _array.Length; i++)
        //{
        //    _sum += _array[i];
        //    Console.WriteLine(_sum);
        //}

        //Task 3
        //int[] _array = { 1, 2, 5, 6, 15, 5, 12 };

        //int _maxElement = int.MinValue;

        //for (int i = 0; i < _array.Length; i++)
        //{
        //    if (_maxElement < _array[i])
        //    {
        //        _maxElement = _array[i];
        //    }

        //    Console.WriteLine(_array[i]);
        //}

        //Console.WriteLine($"Max Element array =  {_maxElement}");
    }
}

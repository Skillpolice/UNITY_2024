using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_TEST_WORK_INPUT_PASSWORD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int _runToUsd = 64;
            int _usdToRub = 94;

            float _rubInWallet;
            float _usdInWallet;

            float _exchangeCurrencyCount;
            string _desiredOperation;

            Console.WriteLine("Welcome ATM: ");
            Console.Write("Input your RUB money: ");
            _rubInWallet = Convert.ToSingle(Console.ReadLine());

            Console.Write("Input your USD money: ");
            _usdInWallet = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nSelect the required operation: ");
            Console.WriteLine("1. RUB to USD: ");
            Console.WriteLine("2. USD to RUB: ");
            Console.Write("\nYour Choice: ");
            _desiredOperation = Console.ReadLine();

            switch (_desiredOperation)
            {
                case "1":
                    Console.WriteLine("RUB to USD");
                    Console.Write("How many change your money? ");
                    _exchangeCurrencyCount = Convert.ToInt32(Console.ReadLine());

                    if (_rubInWallet >= _exchangeCurrencyCount)
                    {
                        _rubInWallet -= _exchangeCurrencyCount;
                        _usdInWallet += _exchangeCurrencyCount / _runToUsd;

                    }
                    else
                    {
                        Console.WriteLine("Do you have any money ! ");
                    }

                    break;
                case "2":
                    Console.WriteLine("USD to RUB");
                    Console.Write("How many change your money? ");
                    _exchangeCurrencyCount = Convert.ToInt32(Console.ReadLine());

                    if (_usdInWallet >= _exchangeCurrencyCount)
                    {
                        _usdInWallet -= _exchangeCurrencyCount;
                        _rubInWallet += _exchangeCurrencyCount * _usdToRub;

                    }
                    else
                    {
                        Console.WriteLine("Do you have any money ! ");
                    }


                    break;
                default:
                    Console.WriteLine("I DONT KNOW !!!");
                    break;
            }

            Console.WriteLine($"Your blance : {_rubInWallet} RUB " + $"{_usdInWallet} USD");



            //INPUT PASSWORD
            //string _password;
            //string _savwPassword;

            //Console.Write("Enter the password to save it: ");
            //_password = Console.ReadLine();

            //_savwPassword = _password;

            //Console.Write("Input Pass: ");
            //_password = Console.ReadLine();


            //if (_password == _savwPassword)
            //{
            //    Console.WriteLine("\nWelcome Your Site.");
            //}
            //else
            //{
            //    Console.WriteLine("\nGoodBye !!!");
            //}



        }
    }
}

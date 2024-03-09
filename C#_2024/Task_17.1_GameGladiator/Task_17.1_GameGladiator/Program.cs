using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_17._1_GameGladiator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            //Player 1
            float _p1Health = rand.Next(90, 100);
            int _p1Damage = rand.Next(5, 52);
            int _p1Armor = rand.Next(50, 100);

            //Player 2
            float _p2Health = rand.Next(90, 100);
            int _p2Damage = rand.Next(5, 50);
            int _p2Armor = rand.Next(50, 100);


            Console.WriteLine($"Player 1: Health {_p1Health} - Damage {_p1Damage} - Armor {_p1Armor}");
            Console.WriteLine($"Player 2: Health {_p2Health} - Damage {_p2Damage} - Armor {_p2Armor}");

            while (_p1Health > 0 && _p2Health > 0)
            {
                _p1Health -= Convert.ToSingle(rand.Next(0, _p2Damage + 1)) / 100 * _p1Armor;
                _p2Health -= Convert.ToSingle(rand.Next(0, _p1Damage + 1)) / 100 * _p2Armor;


                Console.WriteLine("Health Player 1: " + _p1Health);
                Console.WriteLine("Health Player 2: " + _p2Health);
            }

            if (_p1Health <= 0 && _p2Health <= 0)
            {
                Console.WriteLine("Draw");
            }
            else if(_p1Health <=0)
            {
                Console.WriteLine("Player 1 die");
            }
            else if(_p2Health <=0)
            {
                Console.WriteLine("Player 2 die");
            }




        }
    }
}

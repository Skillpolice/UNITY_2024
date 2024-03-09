using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_33_OOP_GeneralClass_Warrior.Classes;

namespace Task_33_OOP_GeneralClass_Warrior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight(100, 10);
            Barbarian barbarian = new Barbarian(100, 1, 7, 2);

            knight.TakeDamage(500);
            barbarian.TakeDamage(250);

            Console.Write("Knight: ");
            knight.ShowInfo();

            Console.Write("Barbarian: ");
            barbarian.ShowInfo();

            

        }
    }
}

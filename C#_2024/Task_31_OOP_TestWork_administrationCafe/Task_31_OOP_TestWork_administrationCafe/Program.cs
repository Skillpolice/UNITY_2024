using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_31_OOP_TestWork_administrationCafe.Classes;

namespace Task_31_OOP_TestWork_administrationCafe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isOpen = true;
            bool isReservationCompleted;
            int wishTable;
            int desiredPlaces;

            Table[] tables = { new Table(1, 5), new Table(2, 4), new Table(3, 15) };

            while (isOpen)
            {
                Console.WriteLine("Администрирование Кафе!\n");

                for (int i = 0; i < tables.Length; i++)
                {
                    tables[i].ShowInfo();
                }

                Console.Write("\nВведите номер стола который хотите забронировать: ");
                wishTable = (Convert.ToInt32(Console.ReadLine()) - 1);

                while (wishTable > (tables.Length - 1) || wishTable < 0)
                {
                    Console.WriteLine("\nТакого стала нет!");
                    Console.Write("\nВведите номер стола который хотите забронировать: ");
                    wishTable = (Convert.ToInt32(Console.ReadLine()) - 1);
                }

                Console.Write("\nВведите сколько мест хотите забронировать: ");
                desiredPlaces = Convert.ToInt32(Console.ReadLine());

                isReservationCompleted = tables[wishTable].Reserve(desiredPlaces);
                if (isReservationCompleted)
                {
                    Console.WriteLine("Бронь прошла успешно!!!");
                }
                else
                {
                    Console.WriteLine("Бронь не прошла, не достаточно мест!!!");
                }


                Console.ReadKey();
                Console.Clear();
            }




        }
    }
}

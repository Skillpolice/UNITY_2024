using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_31_OOP_TestWork_administrationCafe.Classes
{
    class Table
    {
        public int Number;
        public int MaxPlaces;
        public int FreePlaces;

        public Table(int number, int maxPlaces)
        {
            Number = number;
            MaxPlaces = maxPlaces;
            FreePlaces = maxPlaces;
        }

        public bool Reserve(int places) //Если мест хватает выводим True в противном случае False (Метод для расчёта мест)
        {
            if (FreePlaces >= places)
            {
                FreePlaces -= places;
                return true;
            }
            else { return false; }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Стол: {Number} Свободных мест: {FreePlaces} из {MaxPlaces} ");
        }


    }
}

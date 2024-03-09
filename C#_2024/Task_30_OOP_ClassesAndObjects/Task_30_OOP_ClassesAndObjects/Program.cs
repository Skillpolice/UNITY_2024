using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_30_OOP_ClassesAndObjects.Classes;

namespace Task_30_OOP_ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args) //Функции
        {
            //Car Toyota = new Car("Toyota", 31 , 90, 220, "Серый");
            Car Toyota = new Car();

            Toyota.ShowTechicalPasport();
     
        }
    }
}

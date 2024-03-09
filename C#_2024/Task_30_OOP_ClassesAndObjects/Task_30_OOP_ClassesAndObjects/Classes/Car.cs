using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_30_OOP_ClassesAndObjects.Classes
{
    class Car
    {
        public string Name;
        public string Color;
        public int HorsePower;
        public int Age;
        public float Speed;

        public Car(string nameCar, int ageCar, int horsePowerCar, float speedCar, string colorCar) //конструктор
        {
            if (HorsePower < 0 || Age < 0 || Speed < 0)
            {
                HorsePower = 1;
                Speed = 1;
                Age = 1;
            }
            else
            {
                Age = ageCar;
                Speed = speedCar;
                HorsePower = horsePowerCar;
            }

            Name = nameCar;
            Color = colorCar;
        }

        public Car()
        {
            Name = "Ford";
            Age = 0;
            HorsePower = 500;
            Speed = 360.0f;
            Color = "Black";
        }

        public void ShowTechicalPasport() //Метод
        {
            Console.WriteLine($"Название авто: {Name}\nВозвраст машины: {Age}\nКол-во лошадиных сил: {HorsePower}\nСкороксть машины: {Speed} км/ч \nЦвет машины: {Color}");
        }

        public void BecomeOld(int years, int runAwayHorses, float speed)
        {
            Age += years;
            HorsePower -= runAwayHorses;
            Speed -= speed;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_39__OOP_AdstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = { new Car(), new Train() };

            foreach (var vehicle in vehicles)
            {
                vehicle.Move();
            }

        }

        abstract class Vehicle
        {
            protected float _speed;

            public abstract void Move();

            public float GetCurrentSpeed()
            {
                return _speed;
            }
        }

        class Car : Vehicle
        {
            public override void Move()
            {
                Console.WriteLine("Машина едет");
            }
        }

        class Train : Vehicle
        {
            public override void Move()
            {
                Console.WriteLine("Поезд едет");
            }
        }


    }
}

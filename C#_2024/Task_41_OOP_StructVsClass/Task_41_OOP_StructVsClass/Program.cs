using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_41_OOP_StructVsClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GameObject bullet = new GameObject();
            Console.WriteLine(bullet.Position.X);

            Vector2 newPosition = bullet.Position;
            newPosition.X = 50;
            bullet.Position = newPosition;

            Console.WriteLine(bullet.Position.X);
        }

        class GameObject
        {
            public Vector2 Position { get; set; }

        }

        struct Vector2
        {
            public int X, Y;

            public Vector2(int x, int y)
            {
                Y = y;
                X = x;
            }

        }


    }
}

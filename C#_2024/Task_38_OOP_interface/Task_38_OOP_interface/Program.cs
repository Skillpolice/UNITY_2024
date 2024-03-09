using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task_38_OOP_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMoveble car = new Car();

        }

        interface IMoveble
        {
            void Move();
            void ShowMoveSpeed();
        }

        interface Iburnable
        {
            void Burn();
        }


        class Car : IMoveble, Iburnable
        {
            public void Burn()
            {
                
            }

            public void Move()
            {

            }

            public void ShowMoveSpeed()
            {
                
            }
        }


    }
}

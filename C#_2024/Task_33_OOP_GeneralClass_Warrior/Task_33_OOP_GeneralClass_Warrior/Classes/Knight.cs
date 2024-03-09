using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_33_OOP_GeneralClass_Warrior.Classes
{
    class Knight : Warrior
    {
        public Knight(int health, int damage) : base(health, damage, 5) { }


        public void Pray()
        {
            Armor += 2;
        }
    }
}

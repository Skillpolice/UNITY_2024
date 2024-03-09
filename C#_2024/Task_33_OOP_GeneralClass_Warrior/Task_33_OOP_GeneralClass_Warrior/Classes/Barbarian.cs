using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_33_OOP_GeneralClass_Warrior.Classes
{
    class Barbarian : Warrior
    {
        public int AttakSpeed;

        public Barbarian(int health, int damage, int armor, int attakSpeed) : base(health, (damage * attakSpeed), armor) { }

        public void Shot()
        {
            Armor -= 2;
            Health += 10;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_36_OOP_Virtual_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NonPlayerCharacter[] characters =
            {
                new NonPlayerCharacter(),
                new Farmer(),
                new Knight(),
                new Child()
            };

            foreach (NonPlayerCharacter character in characters)
            {
                character.ShowDescription();
                Console.WriteLine(new string('-', 20));
            }

        }
    }

    class NonPlayerCharacter
    {
        public virtual void ShowDescription()
        {
            Console.WriteLine("Я NPC и я просто гуляю.");
        }
    }

    class Farmer : NonPlayerCharacter
    {
        public override void ShowDescription()
        {
            base.ShowDescription();
            Console.WriteLine("А ещё я фермер и умею убирать поле.");
        }
    }

    class Knight : NonPlayerCharacter
    {
        public override void ShowDescription()
        {
            Console.WriteLine("Я рыцарь, мое дело сражение !!!");
        }
    }

    class Child : NonPlayerCharacter
    {


    }

}

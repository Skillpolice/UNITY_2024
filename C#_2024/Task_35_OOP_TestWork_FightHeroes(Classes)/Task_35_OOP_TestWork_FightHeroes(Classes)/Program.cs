using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_35_OOP_TestWork_FightHeroes_Classes_.Classes;

namespace Task_35_OOP_TestWork_FightHeroes_Classes_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int fighterNumbers; //Переменная для выбора бойа


            Fighter[] fighters = // Делаем Массив Бойцов
            {
                new Fighter("Denis", 500, 50, 0),
                new Fighter("Katya", 250, 25, 20),
                new Fighter("Roman", 150, 100, 10),
                new Fighter("Ivan", 300, 75, 5)

            };

            for (int i = 0; i < fighters.Length; i++) // Выводим бойцов
            {
                Console.Write((i + 1) + " ");
                fighters[i].ShowStats();

            }

            Console.WriteLine("\n** " + new string('-', 22) + " **"); // new string('-',25) - Чтобы в ручную не вводить символы))

            Console.Write("\nВыберите первого бойца: ");
            fighterNumbers = Convert.ToInt32(Console.ReadLine()) - 1;

            while (fighterNumbers > (fighters.Length - 1) || fighterNumbers < 0)
            {
                Console.WriteLine("\nВы выбрали не правильный номер бойца.\nТакого бойца нету!!!");
                Console.Write("\nВыберите номер бойца: ");
                fighterNumbers = Convert.ToInt32(Console.ReadLine()) - 1;
            }

            Fighter firstFighter = fighters[fighterNumbers]; //Создаем нового бойца, и присваиваем ему знаечение одного из элемента массива бойцов

            Console.Write("\nВыберите второго бойца: ");
            fighterNumbers = Convert.ToInt32(Console.ReadLine()) - 1;

            while (fighterNumbers > (fighters.Length - 1) || fighterNumbers < 0)
            {
                Console.WriteLine("\nВы выбрали не правильный номер бойца.\nТакого бойца нету!!!");
                Console.Write("\nВыберите номер бойца: ");
                fighterNumbers = Convert.ToInt32(Console.ReadLine()) - 1;
            }

            Fighter secondFighter = fighters[fighterNumbers]; //Создаем нового бойца, и присваиваем ему знаечение одного из элемента массива бойцов

            //Console.WriteLine($"\nВы выбрали бойцов: {firstFighter} || {secondFighter}");

            Console.WriteLine("\n** " + new string('-', 22) + " **");

            while (firstFighter.Health > 0 && secondFighter.Health > 0) //Выводим бой между выбраннами бойцами из массива 
            {
                firstFighter.TakeDamage(secondFighter.Damage);
                secondFighter.TakeDamage(firstFighter.Damage);

                firstFighter.ShowCurrentHealth();
                secondFighter.ShowCurrentHealth();
            }



            Console.ReadKey(true);
        }
    }
}

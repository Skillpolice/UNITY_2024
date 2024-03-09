using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_27_Collection_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(22);
            numbers.Add(12);

            
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}

//numbers.AddRange(new int[] { 1, 2, 3, 4, 5 }); //Добавление в массива в существующий массив
//numbers.RemoveAt(3); //удаление числа в массиве по индексу
//numbers.Remove(22); //удаление числа совподающего с числом в массиве 
//numbers.Clear(); //удаление всего массива
//numbers.Insert(1, 123); //Добовляет элемент в любой индекс листа(массива) 
//Console.WriteLine("Число 22 находиться на позиции: " + numbers.IndexOf(22));
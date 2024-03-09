using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_28._1__Collections_STAK_FILO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();

            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            numbers.Push(5);

            //Console.WriteLine(numbers.Peek());

            //numbers.Pop();

            while (numbers.Count > 0)
            {
                Console.WriteLine("Следующее число в стэке: " + numbers.Pop());
            }

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

        }
    }
}


// POP - извлекает обьект из колекции удаляя его
// Peek - выводит последний элемент в колекции
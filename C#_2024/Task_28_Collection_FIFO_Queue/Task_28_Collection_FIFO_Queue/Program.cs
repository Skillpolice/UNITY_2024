using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_28_Collection_FIFO_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> patients = new Queue<string>(); //1 пришел 1 вышел

            patients.Enqueue("Denis");
            patients.Enqueue("Roman");
            patients.Enqueue("Katya");
            patients.Enqueue("Misha");

            Console.WriteLine("Сейчас идет на прием пациент: " + patients.Dequeue());
            Console.WriteLine("Слудующий в очереди: " + patients.Peek());

            foreach (var patient in patients)
            {
                Console.WriteLine(patient.ToString());
            }
        }
    }
}


// Dequeue - достает из списка 1 элемент и вычеркивает его
// Peek - Слудующий элемент в колекции
// Queue<string> patients = new Queue<string>(); //1 пришел 1 вышел
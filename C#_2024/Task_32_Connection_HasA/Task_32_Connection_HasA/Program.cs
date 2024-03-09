using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32_Connection_HasA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Performer worker1 = new Performer("Denis");
            Performer worker2 = new Performer("Katya");

            Task[] tasks = { new Task(worker1, "Выкапывать яму"), new Task(worker2, "Готовить еду") };

            Board board = new Board(tasks);
            board.ShowAllTasks();

        }
    }

    class Performer
    {
        public string Name;
        public Performer(string name)
        {
            Name = name;
        }
    }

    class Board
    {
        public Task[] Tasks;

        public Board(Task[] tasts)
        {
            Tasks = tasts;
        }

        public void ShowAllTasks()
        {
            for (int i = 0; i < Tasks.Length; i++)
            {
                Tasks[i].ShowInfo();
            }
        }
    }

    class Task
    {
        public Performer Worker;
        public string Description;

        public Task(Performer worker, string description)
        {
            Worker = worker;
            Description = description;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"Ответственный: {Worker.Name}\nОписание задачи: {Description}\n");
        }
    }

}

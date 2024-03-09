using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32_Connection_HasA.Classes
{
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
            Console.WriteLine($"Ответственный: {Worker}\nОписание задачи: {Description}\n");
        }
    }
}

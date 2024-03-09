using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32_Connection_HasA.Classes
{
    internal class Board
    {
        public Task[] Tasks;

        public Board(Task[] tasts)
        {
            Tasks = tasts;
        }

        public void ShowAllTasks()
        {
            for (var i = 0; i < Tasks.Length; i++)
            {
                Tasks[i].ShowInfo();
            }
        }

    }
}

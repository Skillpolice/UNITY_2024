using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK_OOP_GAME_MAIN_TEST_PRACTICAL.Classes;

namespace TASK_OOP_GAME_MAIN_TEST_PRACTICAL
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            ComputerClub computerClub = new ComputerClub(10);
            computerClub.Work();
        }
    }
}

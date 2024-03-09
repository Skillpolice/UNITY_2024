using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_34_OOP_Incapsulation_Player.Classes
{
    class Renderer 
    {
        public void DrawPlayer(int x, int y, char Character = '@')
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write(Character);
            Console.ReadKey(true);
        }
    }
}

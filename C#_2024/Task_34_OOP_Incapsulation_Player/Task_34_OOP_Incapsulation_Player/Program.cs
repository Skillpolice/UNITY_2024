using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_34_OOP_Incapsulation_Player.Classes;

namespace Task_34_OOP_Incapsulation_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Renderer renderer = new Renderer();
            Player player = new Player(55, 10);

            renderer.DrawPlayer(player.X, player.Y);

            
        }
    }
}

// Свойста GET - ПОЛУЧАТЬ :: SET - УСТАНАВЛИВАТЬ
// Автореализуемое свойство public int X { get; private set; }

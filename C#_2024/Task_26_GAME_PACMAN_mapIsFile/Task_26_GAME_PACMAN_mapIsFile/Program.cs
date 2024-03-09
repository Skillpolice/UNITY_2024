using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Task_26_GAME_PACMAN_mapIsFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] map = ReadMap("map.txt");

            Console.CursorVisible = false;
            ConsoleKeyInfo pressKey = new ConsoleKeyInfo('w', ConsoleKey.W, false, false, false);

            Task.Run(() =>
            {
                while (true)
                {
                    pressKey = Console.ReadKey();
                }
            });

            int pacManX = 1;
            int pacManY = 1;
            int score = 0;

            while (true)
            {
                Console.Clear();

                MovePersone(pressKey, ref pacManX, ref pacManY, map, ref score);

                Console.ForegroundColor = ConsoleColor.Blue;
                DrawMap(map);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(pacManX, pacManY);
                Console.Write("@");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(34, 0);
                Console.Write($"Score: {score}");

                Thread.Sleep(1000);
            }
        }

        private static void MovePersone(ConsoleKeyInfo pressKey, ref int pacManX, ref int pacManY, char[,] map, ref int score)
        {
            int[] direction = GetDirection(pressKey);
            int nextPacmanPositionX = pacManX + direction[0];
            int nextPacmanPositionY = pacManY + direction[1];

            char nextCell = map[nextPacmanPositionX, nextPacmanPositionY];

            if (nextCell == ' ' || nextCell == '.')
            {
                pacManX = nextPacmanPositionX;
                pacManY = nextPacmanPositionY;

                if (nextCell == '.')
                {
                    score++;
                    map[nextPacmanPositionX, nextPacmanPositionY] = ' ';
                }
            }
        }

        private static int[] GetDirection(ConsoleKeyInfo pressKey)
        {
            int[] direction = { 0, 0 };

            if (pressKey.Key == ConsoleKey.UpArrow)
            {
                direction[1] = -1;
            }
            else if (pressKey.Key == ConsoleKey.DownArrow)
            {
                direction[1] = 1;
            }
            else if (pressKey.Key == ConsoleKey.LeftArrow)
            {
                direction[0] = -1;
            }
            else if (pressKey.Key == ConsoleKey.RightArrow)
            {
                direction[0] = 1;
            }

            return direction;
        }


        private static void DrawMap(char[,] map)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++) //
                {
                    Console.Write(map[x, y]);
                }
                Console.Write("\n");
            }

        }

        private static char[,] ReadMap(string path)
        {
            string[] file = File.ReadAllLines("map.txt");

            char[,] map = new char[GetMaxLenghtLine(file), file.Length]; //считываем сколько элементов по x y

            for (int x = 0; x < map.GetLength(0); x++) //
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    map[x, y] = file[y][x];
                }
            }

            return map;

        }

        private static int GetMaxLenghtLine(string[] lines) //ищем максимальную длину линии максимального числа X
        {
            int maxLenght = lines[0].Length;

            foreach (string line in lines)
            {
                if (line.Length > maxLenght)
                {
                    maxLenght = line.Length;
                }
            }

            return maxLenght;
        }







    }
}

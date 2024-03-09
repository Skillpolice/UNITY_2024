using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_45_OOP_Enum_Game
{
    internal class Program
    {
        //enum Genre : uint - не сможем указывать отрицацельные числа
        enum Genre 
        {
            RPG,
            MMOORPG,
            Action

        }

        static void Main(string[] args)
        {
            List<Game> games = new List<Game>();
            games.Add(new Game("Oblivion", Genre.RPG));
            games.Add(new Game("Destiny 2", Genre.MMOORPG));
            games.Add(new Game("TES", Genre.RPG));
            games.Add(new Game("Harry Potter", Genre.Action));

            foreach (Game game in games)
            {
                game.ShowInfo();
            }

            Console.ReadKey(true);
        }

        class Game
        {
            private string _title;
            private Genre _genre;

            public Game(string title, Genre genre)
            {
                _title = title;
                _genre = genre;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Это игра: {_title}, Жанр: {_genre}");
            }
        }

    }
}

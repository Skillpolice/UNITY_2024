using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_46_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>
            {
                new Player("nagibatel", 220),
                new Player("Skillpolice", 250),
                new Player("Scorpe", 150),
                new Player("Васся", 99)

            };

            var filteredPlayer = players.TakeWhile(player => player.Name.ToUpper().StartsWith("S")).ToList();

            foreach (Player player in filteredPlayer)
            {
                Console.WriteLine(player.Name + " " + player.Level);
            }

        }

        class Player
        {
            public string Name { get; private set; }
            public int Level { get; private set; }

            public Player(string login, int level)
            {
                Name = login;
                Level = level;
            }
        }



    }
}

// Example Выборка

//List<Player> filtersPlayers = new List<Player> { };

//foreach (Player player in players)
//{
//    if (player.Level > 200)
//    {
//        filtersPlayers.Add(player);

//    }
//}

//var filtresPlayers = from Player player in players where player.Level > 200 select player;

//var filteresPlayer2 = players.Where(player => player.Level > 200).Select(player => player);
//var filteresPlayer3 = players.Where(player => player.Name.ToUpper().StartsWith("В")).Select(player => player);


//Example 2 Сортировка

//var orderedPlayerByLevels = players.Where(player => player.Level > 100).OrderBy(player => player.Level);
//var orderedPlayerByLevels = players.OrderBy(player => player.Level);
//var orderedPlayerByLevels = players.OrderByDescending(player => player.Level);

//var newPlayers = from Player player in players select new { Name = player.Name, DateOfBirth = DateTime.Now }; // Создаем нового объект анонимного типа
//var newPlayers2 = players.Select(player => new { Name = player.Name, DateOfBirth = "Monday" }); // Создаем нового объект аннонимного типа - Через метод расширения SELECT

//Example 3 Обьединение 2-х Коллекций и сортировка

//List<Player> players = new List<Player>
//{
//    new Player("nagibatel", 220),
//    new Player("Skillpolice", 250),
//    new Player("Scorpe", 150),
//    new Player("Васся", 99)

//};

//List<Player> players2 = new List<Player>
//{
//    new Player("Jhonny", 300),
//    new Player("Djack", 85)
//};
//var unitedTeam = players.Union(players2).OrderBy(player => player.Level);

//Example 4 Пропуск - SKIP | TAKE - получить(взять) элементы

//var filteredPlayer = players.Take(1);
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TASK_OOP_GAME_MAIN_TEST_PRACTICAL.Classes
{
    class ComputerClub
    {
        private List<Computer> _computers = new List<Computer>();
        private Queue<Client> _clients = new Queue<Client>();

        private int _money = 0;
        string _userInput;

        public ComputerClub(int computesCount) // Конструктор
        {
            Random random = new Random(); // Различные компы за 1 минту

            for (int i = 0; i < computesCount; i++)
            {
                _computers.Add(new Computer(random.Next(5, 15)));
            }

            CreateNewClients(25, random);
        }

        public void CreateNewClients(int coutClietn, Random random) //Метод по созданию клиентов
        {
            for (int i = 0; i < coutClietn; i++)
            {
                _clients.Enqueue(new Client(random.Next(100, 250), random));
            }
        }

        public void Work()
        {
            while (_clients.Count > 0)
            {
                Client newClient = _clients.Dequeue(); //Клиент который стоит 1 в очереди

                Console.WriteLine($"\nБаланс компьютерного клуба: {_money} руб. Ждем клиента.\n ");
                Console.WriteLine($"У вас новый клиент и он хочет взять компьютер на {newClient.DesiredMinuts} минут");

                ShowAllComputersState();

                Console.Write("\nВы Предлагаете ему компьютер под глмером: ");
                _userInput = Console.ReadLine();

                if (int.TryParse(_userInput, out int computerNumber)) // Проверка на правельный ввод в консоль от клиента
                {
                    computerNumber -= 1;
                    if (computerNumber >= 0 && computerNumber < _computers.Count)
                    {
                        if (_computers[computerNumber].IsTake)
                        {
                            Console.WriteLine("ВЫ пытаетесь посадить клиента, за компьютер, который уже занят. Клиент разозлился и ушел");
                        }
                        else
                        {
                            if (newClient.CheckSolvency(_computers[computerNumber]))
                            {
                                Console.WriteLine("Клиент олатил компьтер и сел за номер " + (computerNumber + 1));
                                _money += newClient.Pay();
                                _computers[computerNumber].BecomTaken(newClient);
                            }
                            else
                            {
                                Console.WriteLine("У клиента не хватило денег и он ушел.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Такого компьютера не существует!!! Клиент разозлился и ушел");
                    }
                }
                else
                {
                    CreateNewClients(1, new Random());
                    Console.WriteLine("Не веррный ввод, попробуйте снова !!!");
                }

                Console.WriteLine("\nЧтобы перейти к след. клиенту, нажмите любую клавишу");
                Console.ReadKey(true);
                Console.Clear();

                SpenOneminute();
            }

            
        }

        private void ShowAllComputersState()
        {
            Console.WriteLine("\nВсе коипьютеры");

            for (int i = 0; i < _computers.Count; i++)
            {
                Console.Write((i + 1) + " - ");
                _computers[i].ShowState();
            }
        }

        private void SpenOneminute()
        {
            foreach (var comp in _computers)
            {
                comp.SpendOneMinutes();
            }
        }

    }
}

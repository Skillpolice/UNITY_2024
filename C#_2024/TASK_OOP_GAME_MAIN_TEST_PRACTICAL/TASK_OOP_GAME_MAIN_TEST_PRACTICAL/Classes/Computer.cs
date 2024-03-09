using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TASK_OOP_GAME_MAIN_TEST_PRACTICAL.Classes
{
    class Computer
    {
        private Client _client;
        private int _minutesRemaining; // Кол-во оставщихся минут
        public bool IsTake
        {
            get
            {
                return _minutesRemaining > 0;
            }
        }

        public int PricePerMinute { get; private set; }

        public Computer(int pricePerMinutes)
        {
            PricePerMinute = pricePerMinutes;
        }

        public void BecomTaken(Client client) //Комп занят
        {
            _client = client;
            _minutesRemaining = _client.DesiredMinuts;
        }

        public void BecomEmpty() //Комп свободен
        {
            _client = null;
        }

        public void SpendOneMinutes() //Отсчёт времени
        {
            _minutesRemaining--;
        }

        public void ShowState() //Текущее состояние компа
        {
            if (IsTake)
                Console.WriteLine($"Компьютер занят. Осталось времени: {_minutesRemaining}");
            else
                Console.WriteLine($"Компьютер свободен, цена за минуту: {PricePerMinute}");
        }


    }
}

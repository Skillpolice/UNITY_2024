using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_OOP_GAME_MAIN_TEST_PRACTICAL.Classes
{
    class Client
    {
        private int _money;
        private int _moneyToPay;

        public int DesiredMinuts { get; private set; } //Сколько минут у клиента 

        public Client(int money, Random ramdom)
        {
            _money = money;
            DesiredMinuts = ramdom.Next(10, 30);

        }

        public bool CheckSolvency(Computer computer) //Проверка, Сможет ли клиент оплатить компьютер
        {
            _moneyToPay = DesiredMinuts * computer.PricePerMinute;

            if (_money >= _moneyToPay)
            {
                return true;
            }
            else
            {
                _money = 0;
                return false;
            }
        }

        public int Pay() //Оплата 
        {
            _money -= _moneyToPay;
            return _moneyToPay;
        }

    }
}

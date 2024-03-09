using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_35_OOP_TestWork_FightHeroes_Classes_.Classes
{
    class Fighter
    {
        private string _name;
        private int _health;
        private int _damage;
        private int _armor;

        public int Health { get { return _health; } }
        public int Damage { get { return _damage; } }

        public Fighter(string name, int health, int damage, int armor)
        {
            _name = name;
            _health = health;
            _damage = damage;
            _armor = armor;
        }

        public void ShowStats()
        {
            Console.WriteLine($"Боец:{_name}, Здоровье:{_health}, Урон:{_damage}, Броня:{_armor}");
        }

        public void ShowCurrentHealth()
        {
            Console.WriteLine($"{_name} здоровье: {_health}");
        }

        public void TakeDamage(int damage)
        {
            _health -= _damage - _armor;
        }
    }
}

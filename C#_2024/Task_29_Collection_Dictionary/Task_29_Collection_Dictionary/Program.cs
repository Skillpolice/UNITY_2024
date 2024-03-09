using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_29_Collection_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> countriesCapitals = new Dictionary<string, string>();

            countriesCapitals.Add("Belarus", "Minsk");
            countriesCapitals.Add("Australia", "Kanberra");
            countriesCapitals.Add("Russia", "Moscow");
            countriesCapitals.Add("USA", "Washington DC");

            countriesCapitals.Remove("Belarus");


            foreach (var key in countriesCapitals.Keys)
            {
                Console.WriteLine($"Страна - {key}");
            }
            
            foreach (var value in countriesCapitals.Values)
            {
                Console.WriteLine($"Сталица - {value}");
            }

        }
    }
}


// Dictionary<string, string> - 1 str .Key , 2 str .Value(значение)
// ContainsKey - Найти по ключу
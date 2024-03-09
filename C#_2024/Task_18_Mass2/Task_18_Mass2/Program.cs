using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_18_Mass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;

            string[,] books =
            {
                { "Пушкин", "Лермонтов", "Есенин" },
                { "Мартиг", "Шелл", "Тепляков" },
                { "Кинг", "Лавкрафт", "Стокер" }
            };

            while (isOpen)
            {
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("Список Авторов: ");

                for (int i = 0; i < books.GetLength(0); i++)
                {
                    for (int j = 0; j < books.GetLength(1); j++)
                    {
                        Console.Write(books[i, j] + " | ");
                    }

                    Console.WriteLine();
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Библиотека");
                Console.WriteLine("1 - Узнать имя Автора по имени. \n2 - Найти книгу по автору. \n3 - Выйти из программы.");
                Console.Write("\nВыберите пункт меню: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int line, colimn;

                        Console.Write("Введите номер полки: ");
                        line = (Convert.ToInt32(Console.ReadLine()) - 1);
                        if (line < 0)
                        {
                            Console.WriteLine("Error line");
                            break;
                        }

                        Console.Write("Введите номер столбца: ");
                        colimn = (Convert.ToInt32(Console.ReadLine()) - 1);
                        if (colimn < 0)
                        {
                            Console.WriteLine("Error colimn");
                            break;
                        }

                        Console.WriteLine($"Автор - {books[line, colimn]}");
                        break;

                    case 2:
                        string author;
                        bool authorIsFoun = false;

                        Console.Write("Введите автора: ");
                        author = Console.ReadLine();
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                if (author.ToLower() == books[i, j].ToLower()) //приводик в регистру написания и поиска Автора
                                {
                                    Console.Write($"Автор {books[i, j]} находиться по адресу полка {i + 1} место {j + 1}");
                                    authorIsFoun = true;
                                }
                            }
                        }

                        if (authorIsFoun == false)
                        {
                            Console.WriteLine("Такого автора нет !!!");
                        }
                        break;

                    case 3:
                        isOpen = false;
                        break;

                    default:
                        Console.WriteLine("Введена не верная программа.");
                        break;
                }

                if (isOpen)
                {
                    Console.WriteLine("\nНажмите любую клавишу для продолжения.");
                }




                Console.ReadKey();
                Console.Clear();


            }




        }

        //TASK 1

        //int[,] _array;
        //int[,] _array2 = new int[3, 3];
        //int[,] _array3 =
        //{
        //    { 1 ,2, 3},
        //    { 4, 5, 6},
        //    { 7, 8, 9}
        //};

        //int[,] _array4 = new int[3, 3]
        //{
        //    { 1, 2, 3 },
        //    { 1, 2, 3 },
        //    { 2, 3, 4 }
        //};

        //Console.WriteLine(_array3.Length);

        //for (int i = 0; i < _array3.GetLength(0); i++)
        //{
        //    for (int j = 0; j < _array3.GetLength(1); j++)
        //    {
        //        Console.Write(_array3[i, j] + " ");
        //    }
        //    Console.WriteLine(" ");
        //}


        //TASK 2 RANDOM

        //Random rand = new Random();

        //int[,] _array3 = new int[4, 4];

        //for (int i = 0; i < _array3.GetLength(0); i++)
        //{
        //    for (int j = 0; j < _array3.GetLength(1); j++)
        //    {
        //        _array3[i, j] = rand.Next(0, 10);
        //        Console.Write(_array3[i, j] + " ");
        //    }

        //    Console.WriteLine();
        //}
    }
}

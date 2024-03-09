using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_44___OOP_Pattern_Matching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persone persone = new Mentor("Jim", 10);


            switch (persone)
            {
                case Mentor mentor:
                    mentor.ShowName();
                    Console.WriteLine(mentor.NumberOfStudent);
                    break;

                case Student student:
                    student.ShowName();
                    Console.WriteLine(student.AverageScore);
                    break;
            }






            // Pattern Matching
            //if (persone is Mentor mentor)
            //{
            //    mentor.ShowName();
            //    Console.WriteLine(mentor.NumberOfStudent);
            //}
        }

        class Persone
        {
            public string Name { get; private set; }

            public Persone(string name)
            {
                Name = name;
            }

            public void ShowName()
            {
                Console.WriteLine($"Я - {Name}");
            }
        }

        class Mentor : Persone
        {
            public int NumberOfStudent { get; private set; }

            public Mentor(string name, int numberOfStudent) : base(name)
            {
                NumberOfStudent = numberOfStudent;
            }
        }

        class Student : Persone
        {
            public int AverageScore { get; private set; }

            public Student(string name, int averageCore) : base(name)
            {
                AverageScore = averageCore;
            }

        }
    }
}


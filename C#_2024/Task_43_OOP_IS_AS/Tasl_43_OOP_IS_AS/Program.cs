using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasl_43_OOP_IS_AS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persone persone = new Mentor("Jim", 10);
            Mentor mentor;
            Student student;

            if(persone is Mentor)
            {
                mentor = (Mentor)persone;
                mentor.ShowName();
                Console.WriteLine(mentor.Name + " " + mentor.NumberOfStudent);
            }
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

// AS - преобразовывем без ошибок
// IS - типа bool - Можем ли мы преобразовывать 

// AS
//Persone persone = new Student("Denis", 10);
//Mentor mentor = persone as Mentor;
//Student student = persone as Student;

//if (mentor != null)
//{
//    mentor.ShowName();
//    Console.WriteLine(mentor.NumberOfStudent);
//}
//if (student != null)
//{
//    student.ShowName();
//    Console.WriteLine(student.AverageScore);
//}
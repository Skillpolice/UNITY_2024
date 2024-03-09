using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task_37_Pattern_Update.Classes;

namespace Task_37_Pattern_Update
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Behaviour[] behaviours =
            {
                new Walker(),
                new Jumper()

            };

            while (true)
            {
                foreach (var behavior in behaviours)
                {
                    behavior.UpDate();
                    Thread.Sleep(1000);

                }
            }


        }
    }




}

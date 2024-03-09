using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Convertation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int _age;
            //string _input = "14";
            //_age = Convert.ToInt32(_input);
            //Console.WriteLine(_age);

            //float _result;
            //int _x = 5;
            //int _y = 2;
            //_result = Convert.ToSingle(_x) / _y;
            //Console.WriteLine(_result);

            int _trigger = 1;
            bool _triggetInBoolean = Convert.ToBoolean(_trigger);
            Console.WriteLine(_triggetInBoolean);
            int _reconvert = Convert.ToInt32(_trigger);
            Console.WriteLine(_trigger);

        }
    }
}

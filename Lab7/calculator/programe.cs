using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome ");

            BasicCal a1 = new BasicCal();

            Console.WriteLine(a1.sum(25, 7));
            Console.WriteLine(a1.sub(98, 5));
            Console.WriteLine(a1.multiplication(20, 5));
            Console.WriteLine(a1.division(56, 6));



            Console.ReadKey();


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Practice Problems");
            Console.WriteLine("1.Minimum Integer\n");
            Console.WriteLine("Chhose your Option\n");
            int Option =Convert.ToInt32(Console.ReadLine());

            switch(Option)
            {
                case 1:
                    MinInteger.GivenIntegers(100, 201, 30);
                    break;
            }
            Console.ReadLine();
        }
    }
}

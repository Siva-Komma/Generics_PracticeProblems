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
            Console.WriteLine("1.Minimum Integer\n2.Minimum FloatValue\n");
            Console.WriteLine("Choose your Option\n");
            int Option =Convert.ToInt32(Console.ReadLine());

            switch(Option)
            {
                case 1:
                    MinInteger.GivenIntegers(100, 201, 30);
                    break;
                case 2:
                    MinimumFloatValue.GivenFloatValues(10.2f, 20.3f, 40.2f);
                    break;
            }
            Console.ReadLine();
        }
    }
}

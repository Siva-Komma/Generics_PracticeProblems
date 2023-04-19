using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracticeProblems
{
    public class MinInteger
    {
        public static int GivenIntegers(int Firstvalue, int Secondvalue, int Thirdvalue)
        {
            if (Firstvalue.CompareTo(Secondvalue) < 0 && Firstvalue.CompareTo(Thirdvalue) < 0 ||
               Firstvalue.CompareTo(Secondvalue) <= 0 && Firstvalue.CompareTo(Thirdvalue) < 0 ||
               Firstvalue.CompareTo(Secondvalue) < 0 && Firstvalue.CompareTo(Thirdvalue) <= 0)
            {
                Console.WriteLine($"First vale {Firstvalue} is Minimum than Second value {Secondvalue} and Third value {Thirdvalue}");
                return Firstvalue;
            }
            if (Secondvalue.CompareTo(Firstvalue) < 0 && Secondvalue.CompareTo(Thirdvalue) < 0 ||
                Secondvalue.CompareTo(Firstvalue) <= 0 && Secondvalue.CompareTo(Thirdvalue) < 0 ||
                Secondvalue.CompareTo(Firstvalue) < 0 && Secondvalue.CompareTo(Thirdvalue) <= 0)
            {
                Console.WriteLine($"Second vale {Secondvalue} is Minimum than First value {Firstvalue} and Third value {Thirdvalue}");
                return Secondvalue;
            }
            if (Thirdvalue.CompareTo(Firstvalue) < 0 && Thirdvalue.CompareTo(Secondvalue) < 0 ||
               Thirdvalue.CompareTo(Firstvalue) <= 0 && Thirdvalue.CompareTo(Secondvalue) < 0 ||
               Thirdvalue.CompareTo(Firstvalue) < 0 && Thirdvalue.CompareTo(Secondvalue) <= 0)
            {
                Console.WriteLine($"Third value {Thirdvalue} is Minimum than  First vale {Firstvalue} and Second value {Secondvalue}");
                return Thirdvalue;
            }
            return Firstvalue;
        }
    }
}

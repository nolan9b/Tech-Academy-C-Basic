using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Method_Test mt = new Method_Test();

            int intVar = 12;
            decimal decVar = 1618;

            Console.WriteLine("12 + 20 is: " + mt.DoMath(intVar));
            Console.WriteLine("1618 / 202.25 is: " + mt.DoMath(decVar));
            Console.WriteLine("Converting \"8\" to int and times by 20: " + mt.DoMath("8"));

            Console.ReadLine();
        }
    }
}

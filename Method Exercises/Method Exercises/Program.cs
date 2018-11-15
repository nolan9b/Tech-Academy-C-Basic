using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodTest mt = new MethodTest();

            mt.Sum(20, 30);

            mt.Sum(num1: 40, num2: 50);

            Console.ReadLine();
        }

        
    }
}

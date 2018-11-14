using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("What number do you want to do maths on?");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The number add twenty is: " + calc.AddTwenty(number));
            Console.WriteLine("The number minus twenty is: " + calc.MinusTwenty(number));
            Console.WriteLine("The number times twenty is: " + calc.TimesTwenty(number));

            Console.Read();
        }
    }
}

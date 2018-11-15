using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticClass.Hello();

            ClassMethodTest cmt = new ClassMethodTest();

            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            // Send number to method which displays the number / 2
            // number's value remains as entered
            cmt.outputInt(number);

            // Send the value of the number variable to method and divide that by two
            // number's value is now half its original value
            cmt.outMethod(out number, number);

            // Outut numbers new value / 2
            Console.WriteLine("Mehtod with out parameter");
            Console.WriteLine("{0} divided by 2 is {1}", number, number / 2);

            // output overloaded method
            Console.WriteLine("Overloaded method");
            cmt.outputInt(number, 2);

            Console.ReadLine();
        
        }
    }
}

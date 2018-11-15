using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest3
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodTest mt = new MethodTest();

            Console.Write("Please enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = 0;
            bool isDefault = false;

            try
            {
                Console.Write("Please enter second number (optional): ");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("No second number entered using default...");
                isDefault = true;
            }

            Console.WriteLine((isDefault) ? mt.DoMaths(num1): mt.DoMaths(num1,num2));

            Console.ReadLine();
        }
    }
}

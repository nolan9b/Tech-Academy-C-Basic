using System;

namespace C_Sharp_Maths_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Super Maths --");

            // Ask user for a number and multiply it by 50
            Console.Write("Please enter a number: ");
            long num1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("{0} multiplied by 50 is: {1}", num1, num1 * 50);

            // Ask user for a number and add 25 to it
            Console.Write("Please enter a number: ");
            long num2 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("When {0} has 25 added to it the answer is: {1}", num2, num2 + 25);

            // Ask user for a number and divides by 12.5
            Console.Write("Please enter a number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} divided by 12.5 is: {1}", num3, num3 / 12.5f);

            // Ask user for a number and checks if it is greater than 50 and prints true/false to console
            Console.Write("Please enter a number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            if (num4 > 50) {
                Console.WriteLine("True, the number is > 50");
            } else {
                Console.WriteLine("False the number is less than 50");
            }

            // Ask user for a number and divides it by 7 and prints remainder
            Console.Write("Please enter a number: ");
            int num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("When {0} is divided by 7 the remainder is : {1}", num5, num5 % 7);

            Console.Read();
        }
    }
}

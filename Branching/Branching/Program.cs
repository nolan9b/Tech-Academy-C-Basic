using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Please enter package width:");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package height:");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package length:");
                int length = Convert.ToInt32(Console.ReadLine());

                int dimensions = width + height + length;

                if ((dimensions) > 50)
                {
                    Console.WriteLine("Package is too big to be shipped via Package Express.");
                    Console.Read();
                }
                else
                {
                    float quote = dimensions * weight / 100.0f;
                    Console.WriteLine("The quote for the package is: ${0}", quote);
                    Console.Write("Thank you");
                    Console.Read();
                }


            }
        }
    }
}

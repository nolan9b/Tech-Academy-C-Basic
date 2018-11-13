using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isQuit = false;
            Console.WriteLine("While Loop...");
            while (!isQuit)
            {
                Console.WriteLine("Do you want to quit?");
                string answer = Console.ReadLine();

                if (answer == "yes")
                    isQuit = true;
            }

            isQuit = false;
            Console.WriteLine("Now for the Do While....");
            do
            {
                Console.WriteLine("Do you want to quit?");
                string answer = Console.ReadLine();

                if (answer == "yes")
                    isQuit = true;
            }
            while (!isQuit);
        }
    }
}

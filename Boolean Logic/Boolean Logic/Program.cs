using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? (true or false)");
            bool hadDUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int numTickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified");

            if (age > 15 && !hadDUI && numTickets < 3) {
                Console.WriteLine("true");
            } else {
                Console.WriteLine("false");
            }

            Console.Read();
        }
    }
}

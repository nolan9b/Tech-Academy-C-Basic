using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            File.WriteAllText(@"D:\logs\number.txt", number.ToString());

            Console.WriteLine("The number is: {0}", File.ReadAllText(@"D:\logs\number.txt"));
            Console.ReadLine();
        }
    }
}

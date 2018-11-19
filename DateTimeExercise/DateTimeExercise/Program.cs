using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            DateTime currentTime = DateTime.Now;

            TimeSpan timeSpan = new TimeSpan(0, number, 0, 0);
            DateTime newTime = currentTime.Add(timeSpan);

            Console.WriteLine(newTime);

            Console.ReadLine();

        }
    }
}

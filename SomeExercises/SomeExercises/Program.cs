using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            const string programName = "C Sharp Exercises";
            Console.WriteLine(programName);

            var number = 12345;
            Console.WriteLine("The number is: {0}", number);

            var person1 = new Person("Peter");
            var person2 = new Person("Pan", 12345);

            Console.WriteLine("{0},{1}",person1.Name, person1.Telephone);
            Console.WriteLine("{0},{1}", person2.Name, person2.Telephone);

            Console.ReadLine();
        }
    }
}

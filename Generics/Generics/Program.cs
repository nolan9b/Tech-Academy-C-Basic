using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> stringEmployee = new Employee<string>();
            stringEmployee.Things = new List<string>();

            Employee<int> intEmployee = new Employee<int>();
            intEmployee.Things = new List<int>();

            stringEmployee.Things.Add("Peter");
            stringEmployee.Things.Add("Wendy");
            stringEmployee.Things.Add("Tinkerbell");
            stringEmployee.Things.Add("Hook");

            intEmployee.Things.Add(1);
            intEmployee.Things.Add(2);
            intEmployee.Things.Add(3);
            intEmployee.Things.Add(4);

            foreach(string thing in stringEmployee.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (int intThing in intEmployee.Things)
            {
                Console.WriteLine(intThing);
            }


            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();

            IQuittable iQuit = new Employee();

            iQuit.Quit();

            Console.ReadLine();
        }
    }
}

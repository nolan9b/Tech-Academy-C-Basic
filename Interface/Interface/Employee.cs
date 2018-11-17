using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

        public void Quit()
        {
            Console.WriteLine("I Quit");
        }
    }
}

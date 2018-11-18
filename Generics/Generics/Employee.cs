using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Employee<T> : Person, IQuitabble
    {
        public int Id { get; set; }
        public List<T> Things { get; set; }

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

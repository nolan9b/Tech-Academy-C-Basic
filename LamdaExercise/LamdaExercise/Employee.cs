using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExercise
{
    public class Employee : Person, IQuitabble
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

        public void Quit()
        {
            Console.WriteLine("I Quit");
        }

        public static bool operator ==(Employee firstEmployee, Employee secondEmployee)
        {
            if (firstEmployee.Id == secondEmployee.Id)
            {
                return true;
            }
            else if (firstEmployee.Id != secondEmployee.Id)
            {
                return false;
            }

            return false;
        }
        public static bool operator !=(Employee firstEmployee, Employee secondEmployee)
        {
            if (firstEmployee.Id != secondEmployee.Id)
            {
                return true;
            }
            else if (firstEmployee.Id == secondEmployee.Id)
            {
                return false;
            }

            return false;
        }

    }
}

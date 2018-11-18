using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExercise

{
    class Program
    {
        

        static void Main(string[] args)
        {
            DaysOfTheWeek today = new DaysOfTheWeek();


            Console.WriteLine("Please enter the current day of the week");
            string dayEntered = Console.ReadLine();
            DayOfTheWeek output = new DayOfTheWeek();

            try
            {
                output = (DayOfTheWeek)Enum.Parse(typeof(DayOfTheWeek), dayEntered);
            }
            
            catch (ArgumentException ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            
            Console.ReadLine();
        }

        
    }
}

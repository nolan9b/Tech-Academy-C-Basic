using System;

namespace Variables_and_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- The Tech Academy --");
            Console.WriteLine("-- Student Daily Report --");

            Console.Write("What course are you on: ");
            string courseName = Console.ReadLine();

            Console.Write("What Page Number: ");
            int pageNumber = Convert.ToInt16(Console.ReadLine());

            Console.Write("Do you need help with anything? Please answer \"true\" or \"false\": ");
            bool isHelpNeeded = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Were there any positive experiences you'd like to share? Please five specifics: ");
            string positiveExperiences = Console.ReadLine();

            Console.Write("Is there any other feedback you'd like to provide? Please be specific: ");
            string otherExperiences = Console.ReadLine();

            Console.Write("How many hours did you study today: ");
            byte hoursStudied = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");

            Console.Read();
        }
    }
}

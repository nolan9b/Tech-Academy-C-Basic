using System;

namespace Income_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1:");
            Console.Write("Hourly Rate: ");
            int personOneRate= Convert.ToInt32(Console.ReadLine());
            Console.Write("Hours worked per week: ");
            int personOneHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2:");
            Console.Write("Hourly Rate: ");
            int personTwoRate = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hours worked per week: ");
            int personTwoHours = Convert.ToInt32(Console.ReadLine());

            int personOneWeeklySalary = personOneRate * personOneHours;
            int personTwoWeeklySalary = personTwoRate * personTwoHours;

            Console.WriteLine("Weekly Salary of Person 1:");
            Console.WriteLine(personOneWeeklySalary);

            Console.WriteLine("Weekly Salary of Person 2:");
            Console.WriteLine(personTwoWeeklySalary);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(personOneWeeklySalary > personTwoWeeklySalary ? "True" : "False");

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Peter", "Pan", "and", "the", "lost", "Boys" };

            Console.Write("Please select index of string array (0-5): ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("At that index is: " + stringArray[index]);

            int[] intArray = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            Console.Write("\nPlease select index of int array (0-9): ");
            int intIndex = Convert.ToInt32(Console.ReadLine());

            if (intIndex > 9)
            {
                Console.WriteLine("That Index is too large");
            }
            else
            {
                Console.WriteLine("At that index is: " + intArray[intIndex]);
            }


            List<string> stringList = new List<string>();

            stringList.Add("Frodo");
            stringList.Add("Boromir");
            stringList.Add("Gandalf");
            stringList.Add("Gimli");
            stringList.Add("Legolas");
            stringList.Add("Samwise");
            stringList.Add("Aragorn");
            stringList.Add("Meriadoc");
            stringList.Add("Peregrin");

            Console.Write("\nPlease select an index from the string list: ");
            int listIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("At that index is: " + stringList[listIndex]);

            Console.Read();

        }
    }
}

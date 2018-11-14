using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1
            Console.WriteLine("\nQuestion 1");
            string[] stringArray = { "zero", "one", "two", "three", "four" };
            Console.Write("Please enter some text: ");
            string text = Console.ReadLine();

            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + text;
            }

            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            // Question 2
            // Commenetd out so as to not stall program
            //for (int i = 0; ; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // Question3
            Console.WriteLine("\nQuestion 3");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i);
            }

            // Question 4 
            Console.WriteLine("\nQuestion 4");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i);
            }

            // Question 5
            Console.WriteLine("\nQuestion 5");
            for (int i = 5; i >= 1; i--)
            {
                Console.Write(i);
            }

            // Question 6
            Console.WriteLine("\nQuestion 6");
            List<string> uniqueStrings = new List<string>() { "zero", "one", "two", "three", "four" };

            Console.WriteLine("Please enter text to search for: ");
            string searchText = Console.ReadLine();

            foreach (string str in uniqueStrings)
            {
                if (str == searchText)
                {
                    Console.WriteLine("Index: " + uniqueStrings.IndexOf(str));
                }
            }

            // Question 7
            Console.WriteLine("\nQuestion 7");
            List<string> uniqueStrings2 = new List<string>() { "zero", "one", "two", "three", "four" };

            Console.WriteLine("Please enter text to search for: ");
            string searchText2 = Console.ReadLine();


            if (uniqueStrings2.Contains(searchText2))
            {
                foreach (string str in uniqueStrings2)
                {
                    if (str == searchText2)
                    {
                        Console.WriteLine("Index: " + uniqueStrings2.IndexOf(str));
                    }
                }
            }
            else
            {
                Console.WriteLine("Not in list");
            }

            // Question 8
            Console.WriteLine("\nQuestion 8");
            List<string> uniqueStrings3 = new List<string>() { "zero", "one", "two", "three", "four" };

            Console.WriteLine("Please enter text to search for: ");
            string searchText3 = Console.ReadLine();

            if (uniqueStrings3.Contains(searchText3))
            {
                foreach (string str in uniqueStrings3)
                {
                    if (str == searchText3)
                    {
                        Console.WriteLine("Index: " + uniqueStrings3.IndexOf(str));
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Not in list");
            }

            // Question 9
            Console.WriteLine("\nQuestion 9");
            List<string> dupeStrings = new List<string>() { "zero", "one", "two", "three", "four", "zero", "one", "two", "three", "four" };

            Console.WriteLine("Please enter text to search for: ");
            string searchText4 = Console.ReadLine();

            for (int i = 0; i < dupeStrings.Count; i++)
            {
                if (dupeStrings[i] == searchText4)
                {
                    Console.WriteLine("Index is: " + i);
                }
            }


            // Question 10
            Console.WriteLine("\nQuestion 10");
            List<string> dupeStrings2 = new List<string>() { "zero", "one", "two", "three", "four", "zero", "one", "two", "three", "four" };

            Console.WriteLine("Please enter text to search for: ");
            string searchText5 = Console.ReadLine();
            bool isFound = false;

            for (int i = 0; i < dupeStrings2.Count; i++)
            {
                if (dupeStrings2[i] == searchText5)
                {
                    Console.WriteLine("Index is: " + i);
                    isFound = true;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("Item is not in the list");
            }

            // Question 11
            Console.WriteLine("\nQuestion 11");
            List<string> dupeStrings3 = new List<string>() { "zero", "one", "four", "three", "four", "zero", "one", "two", "three", "two" };
            List<string> dupes = new List<string>();

            foreach (string str in dupeStrings3)
            {
                if (!dupes.Contains(str))
                {
                    Console.WriteLine(str + " has not appeared before.");
                    dupes.Add(str);
                }
                else
                {
                    Console.WriteLine(str + " has appeared in the list before.");
                }
                
            }

            Console.Read();

        }
    }
}

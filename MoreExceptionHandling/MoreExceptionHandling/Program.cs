using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {   int age = 0;
            bool isException = false;

            try
            {
                Console.WriteLine("Please enter age");
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a valid age");
                isException = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went badly wrong...");
            }
            finally
            {
                
                if (age >= 1 && !isException)
                {
                    Console.WriteLine("You were born in: {0}", 2018 - age);
                }
                else if (age <= 0 && !isException)
                {
                    Console.WriteLine("Please enter a positive age.");
                }
            }
            
            Console.ReadLine();
        }
    }
}

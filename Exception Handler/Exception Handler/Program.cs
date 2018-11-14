using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 110, 211, 232, 23, 142, 125, 126, 157, 81, 19, 100 };

            try
            {
                Console.Write("Please enter a number to divide by: ");
                int divisor = Convert.ToInt32(Console.ReadLine());

                foreach (int number in intList)
                {
                    Console.WriteLine(number + " / " + divisor + " = " + number / divisor);
                }
            }
            catch (DivideByZeroException div0)
            {
                Console.WriteLine("You Divided by zero.");
            }
            catch (FormatException form)
            {
                Console.WriteLine(form);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Finally, we have reached Finally");
                Console.ReadLine();
            }

            
        }
    }
}

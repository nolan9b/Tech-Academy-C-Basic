using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    class ClassMethodTest
    {
        public void outputInt(int num)
        {
            Console.WriteLine("{0} divided by 2 is {1}", num, num / 2);
        }



        // Method with out parameters
        public void outMethod(out int number, int num)
        {
            number = num / 2;
            
        }

        // Overloaded method
        public void outputInt(int num, int num2)
        {
            Console.WriteLine("{0} divided by {1} is {2}", num, num2, num / num2);
        }

    }
}

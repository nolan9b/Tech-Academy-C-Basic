using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest3
{
    class MethodTest
    {
        public int DoMaths(int num1, int num2 = 100)
        {
            return num1 * num2;
        }
    }
}

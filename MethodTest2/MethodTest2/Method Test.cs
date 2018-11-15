using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest2
{
    class Method_Test
    {
        public int DoMath(int num)
        {
            return num + 20;
        }

        public int DoMath(decimal num)
        {
            return Convert.ToInt32(num / 202.25m);
        }

        public int DoMath(string num)
        {
            return Convert.ToInt32(num) * 20;
        }
    }
}

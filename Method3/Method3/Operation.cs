using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3
{
    class Operation
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int MathMethod(int num1, int num2 = 38)
        {
            int result = num1 + num2;
            return result;
        }
    }
}

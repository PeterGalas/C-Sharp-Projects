using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    class Program
    {
        public static void Main()
        {
            int opInt = 95;
            Math.mathTime(opInt);

            decimal opDec = 648.21m;
            Math.mathTime(opDec);

            string opString = "9000";
            Math.mathTime(opString);

            Console.ReadLine();
        }
    }
}
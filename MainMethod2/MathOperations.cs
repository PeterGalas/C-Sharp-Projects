using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    public class Math
    {
        public static void mathTime(int opInt)
        {
            int addNum = 37;
            int resAdd = addNum + opInt;//adds 37 + 95 = 132
            Console.WriteLine(resAdd);
        }

        public static void mathTime(decimal opDec)
        {
            decimal decMult = opDec * 15;
            Console.WriteLine(Convert.ToInt32(decMult));//rounded number 648.21m decimal * 15 = 9,723
        }


        public static void mathTime(string opStr)
        {
            decimal strAdd = Convert.ToInt32(opStr) + 100;//9000 + 100 = 9100
            Console.WriteLine(strAdd);
        }
    }
}
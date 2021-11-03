using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method4
{
    public class Class1
    {
        public void MyMethod(int One)
        {
            int result = One / 2;

            Console.WriteLine(One + " divided by 2 = " + result);
            return;
        }
        public void MyMethod(double One)
        {
            double result = One / 2;

            Console.WriteLine(One + " divided by 2 = " + result);
            return;
        }

        public void GetValue(out int One, out int Two)
        {
            Console.WriteLine("Please enter the first value: ");
            One = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second value: ");
            Two = Convert.ToInt32(Console.ReadLine());
        }



    }
}

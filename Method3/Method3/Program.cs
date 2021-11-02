using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3
{
    class Program
    {
        static void Main(string[] args)
        {
                Operation FirstOp = new Operation();
                Console.WriteLine("Please choose a number:");
                FirstOp.num1 = Convert.ToInt32(Console.ReadLine());

                try
                {

                    Console.WriteLine("Pick a second number. Press Enter button if you do not want a second number:");
                    FirstOp.num2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    FirstOp.num2 = 38;

                }
                int sum = FirstOp.MathMethod(FirstOp.num1, FirstOp.num2);
                Console.WriteLine(sum);

                Console.WriteLine("Thanks you!");
                Console.ReadLine();

            }
        }
}

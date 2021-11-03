using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassRevission
{
    public class Program
    {
            public static void Main(string[] args)
            {
                //instantiate class
                Math math = new Math();
                math.num1 = 25;
                math.num2 = 60;

                //takes user input as integer variables and adds them together
                Console.WriteLine("Please enter a number.");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You selected the number " + num1 + ". Please pick a second number.");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second number is " + num2 + ". Multiplying the numbers together...");
                int result = num1 * num2;
                Console.WriteLine("The result is " + result);


                //call class method specifying parameter names
                math.add1(num1, num2);
                Console.ReadLine();
            }
    }
}

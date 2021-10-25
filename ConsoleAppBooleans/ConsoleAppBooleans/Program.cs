using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBooleans
{
    class Program
    {
        static void Main(string[] args)
        {
            int packageWidth = 10;
            int packageHeight = 25;
            bool tooBig = (packageHeight > 25 && packageWidth > 25);
            Console.WriteLine(tooBig);
            Console.ReadLine();

            // Or is represented by the || symbol

            int packageWidth2 = 10;
            int packageHeight2 = 25;
            bool tooBig2 = (packageHeight > 25 || packageWidth > 25);
            Console.WriteLine(tooBig);
            Console.ReadLine();

            string firstName = "Jesse";
            string lastName = "Jhonson";
            string socialSecurityNumber = "123-45-6789";

            bool isAuthorized = (firstName == "Jesse" && lastName == "Jhonson" && socialSecurityNumber == "123-45-6789");
            Console.WriteLine(isAuthorized);
            Console.ReadLine();

            int bankAccountBalance = 500;
            bool isInARockBand = false;
            string name = "Jesse";

            bool isReallyCool = (bankAccountBalance > 10000 || isInARockBand || name == "Jesse");
            Console.WriteLine(isReallyCool);
            Console.ReadLine();

            //both operators can be used in one line of code
            //bool result = (true && (true || false));
            //Console.WriteLine(result);

            int num1 = 7;
            int num2 = 12;
            int num3 = 23;
            int num4 = 14;
            int num5 = 8;
            int num6 = 5;

            bool result = (num1 > num2 && (num3 == num4 || num5 > num6));
            Console.WriteLine(result);
            Console.ReadLine();
            //&& operator true && false = false
            //&& operator true && true = true must be matching
            // || operator
            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || false);
            Console.ReadLine();
            // == easy
            //does not not equal true !=
            Console.WriteLine(true != true);
            Console.WriteLine(true != false);
            Console.WriteLine(false != false);
            Console.ReadLine();
            //X or operator
            Console.WriteLine(true ^ true);
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ false);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express");//company name
            Console.ReadLine();

            Console.WriteLine("What is your package weight?");//package weight
            int packageWeight = Convert.ToInt32(Console.ReadLine());//converts packageWeight to int
            Console.WriteLine("Your package weight is " + packageWeight);// concatenates sentence and weight
            Console.ReadLine();

            if (packageWeight > 50)//if statement packageWeight greater than 50
            {
                Console.WriteLine("Error! package is to heavy to be shipper via Package Express, Have a good day!");//error message
                Console.ReadLine();
            }

            Console.WriteLine("What is your package height?");//height of package
            int packageHeight = Convert.ToInt32(Console.ReadLine());//convert in int packageHeight to int
            Console.WriteLine("Your package height is " + packageHeight);
            Console.ReadLine();

            Console.WriteLine("What is your package length?");
            int packageLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your package length is " + packageLength);
            Console.ReadLine();

            Console.WriteLine("What is your package Width?");
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your package Width is " + packageWidth);
            Console.ReadLine();

            if (packageLength + packageHeight + packageWidth > 50)//if statement if length + width + height greater than 50?
            {
                Console.WriteLine("Package is too big to be shipped via, Package Express!");//cant be shipped
                Console.ReadLine();
                System.Environment.Exit(1);
            }

            //Console.WriteLine("Your quote is ");
            //Console.ReadLine();
            //int total = (packageHeight * packageLength * packageWeight / 100);
            //string Final = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Your quote is " + total);
            //Console.WriteLine(total);
            //Console.ReadLine();

            decimal sum = packageWeight * (packageHeight + packageLength + packageWidth) / 100m; //
            Console.WriteLine("Your total for shipping this is: $" + sum);
            Console.ReadLine();

        }
    }
}

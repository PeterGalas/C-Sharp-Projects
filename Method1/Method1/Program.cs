using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please type in a number.");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The number you picked times 75 is: ");

            Maths multi = new Maths();
            multi.Multi(number);
            Console.ReadLine();

            Console.WriteLine("Your number plus 78 equals: ");

            Maths add = new Maths();
            add.Adding(number);
            Console.ReadLine();

            Console.WriteLine("The number you picked subtracted by 13 equals: ");

            Maths subtract = new Maths();
            subtract.Subtracting(number);
            Console.ReadLine();
            

            Console.WriteLine("The number you entered, divided by 5 equals: ");

            Maths divi = new Maths();
            divi.Divide(number);
            Console.ReadLine();

            Console.WriteLine("The number you entered, divided by 5 equals: ");
            decimal dec = Convert.ToDecimal(Console.ReadLine());

            //Maths dec = new Maths();
            //dec.Decimal(number);
            //Console.ReadLine();

        }
    }
}

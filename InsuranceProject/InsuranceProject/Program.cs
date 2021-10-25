using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Can You please state your age?");
            string age = Console.ReadLine();
            int numYourAge = Convert.ToInt32(age);//converting string into int
            Console.WriteLine("You are currently " + age + " years old?");
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\"");
            bool noDui = Convert.ToBoolean(Console.ReadLine());
            

            if (noDui == true)
            {
                Console.WriteLine("Driver does have a DUI's ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Driver does not have a DUI ");
                Console.ReadLine();
            }

            Console.WriteLine("How many speeding tickets do you have?");
            string numberOfTickets = Console.ReadLine();
            int numTickets = Convert.ToInt32(numberOfTickets);//converting string into int to give a number back
            
            Console.ReadLine();

            if (numYourAge > 15 && noDui && numTickets >= 3)//boolean stating age must be greater than 15, with no Dui, number of tickets 3 or less.
            {
                Console.WriteLine("Congradulations, You are qualified for an insurance plan!");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Sorry, You are not qualified for insurance!");
                Console.ReadLine();
            }
            
           
        }
    }
}

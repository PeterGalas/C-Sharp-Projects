using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now;
            Console.WriteLine("At this moment in time, it is: " + current);
            Console.WriteLine("Enter a number: ");
            string userNum = Console.ReadLine();
            int userInt = Convert.ToInt32(userNum);
            DateTime futureTime = current.AddHours(userInt);

            Console.WriteLine("In " + userInt + " hours, it will be " + futureTime);
            Console.ReadLine();
        }
    }
}
